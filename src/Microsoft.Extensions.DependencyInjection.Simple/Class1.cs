using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    public class ServiceProvider: IServiceProvider, IServiceScopeFactory, IDisposable
    {
        private readonly ServiceProvider _root;
        private readonly ServiceDescriptor[] _services;
        private readonly List<object> _toDispose = new List<object>();
        private readonly Dictionary<ServiceDescriptor, object> _scoped = new Dictionary<ServiceDescriptor, object>();

        public ServiceProvider(IEnumerable<ServiceDescriptor> services)
        {
            _services = services.ToArray();
            _root = this;
        }

        public ServiceProvider(ServiceProvider parent)
        {
            _root = parent._root;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(IServiceScopeFactory))
            {
                return this;
            }
            var descriptor = _services.SingleOrDefault(t => t.ServiceType == serviceType);
            if (descriptor == null)
            {
                return null;
            }
            return Resolve(descriptor);
        }

        private object Resolve(ServiceDescriptor descriptor)
        {
            switch (descriptor.Lifetime)
            {
                case ServiceLifetime.Singleton:
                    return Singleton(descriptor, () => Create(descriptor));
                case ServiceLifetime.Scoped:
                    return Scoped(descriptor, () => Create(descriptor));
                case ServiceLifetime.Transient:
                    return Transient(() => Create(descriptor));
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private object Scoped(ServiceDescriptor descriptor, Func<object> func)
        {
            return Scoped(descriptor, func, this);
        }

        private object Create(ServiceDescriptor descriptor)
        {
            if (descriptor.ImplementationType != null)
            {
                return CreateInstance(descriptor.ImplementationType);
            }
            else if (descriptor.ImplementationFactory != null)
            {
                return descriptor.ImplementationFactory(this);
            }
            else if (descriptor.ImplementationInstance != null)
            {
                return descriptor.ImplementationInstance;
            }
            throw new NotImplementedException();
        }

        private object CreateInstance(Type implementationType)
        {
            return Activator.CreateInstance(implementationType);
        }

        private object Transient(Func<object> func)
        {
            var o = func();
            _toDispose.Add(o);
            return o;
        }

        private static object Scoped(ServiceDescriptor descriptor, Func<object> func, ServiceProvider provider)
        {
            object instance;
            if (provider._scoped.TryGetValue(descriptor, out instance))
            {
                return instance;
            }
            instance = func();
            provider._scoped.Add(descriptor, instance);
            return instance;
        }

        private object Singleton(ServiceDescriptor descriptor, Func<object> func)
        {
            return Scoped(descriptor, func, _root);
        }

        public IServiceScope CreateScope()
        {
            return new ServiceScope(new ServiceProvider(this));
        }

        public void Dispose()
        {
            foreach (var o in _toDispose.Concat(_scoped.Values))
            {
                (o as IDisposable)?.Dispose();
            }
        }
    }

    public class ServiceScope : IServiceScope
    {
        private readonly ServiceProvider _serviceProvider;

        public ServiceScope(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Dispose()
        {
            _serviceProvider.Dispose();
        }

        public IServiceProvider ServiceProvider => _serviceProvider;
    }
}
