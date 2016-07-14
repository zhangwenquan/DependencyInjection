using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    public class DiagnosticServiceProvider: IServiceProvider, IServiceScopeFactory, IDisposable
    {
        private readonly DiagnosticServiceProvider _root;
        private readonly ServiceDescriptor[] _services;
        private readonly List<object> _toDispose = new List<object>();
        private readonly Dictionary<object, object> _scoped = new Dictionary<object, object>();
        private HashSet<Type> _resolutions = new HashSet<Type>();
        private bool _isDisposed;
        public List<ResolutionStep> Traces = new List<ResolutionStep>();

        public DiagnosticServiceProvider(IEnumerable<ServiceDescriptor> services)
        {
            _services = services.ToArray();
            _root = this;
        }

        public DiagnosticServiceProvider(DiagnosticServiceProvider parent)
        {
            _services = parent._services;
            _root = parent._root;
        }

        public object GetService(Type serviceType)
        {
            var step = new ResolutionStep(serviceType);

            step.StackTrace = GetStackTrace();
            if (step.StackTrace.Any(frame=>frame.StartsWith(">")))
            {
                step.Used(Features.Inception);
            }
            var result = GetService(serviceType, step);
            if (_root._resolutions.Add(serviceType))
            {
                Traces.Add(step);
            }
            return result;
        }

        private static string[] GetStackTrace()
        {
            var frames = Environment.StackTrace.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Skip(3);
            var insideDi = false;
            var result = new List<string>();
            foreach (var frame in frames)
            {
                if (frame.Contains("Microsoft.Extensions.DependencyInjection.Simple.ServiceProvider2"))
                {
                    if (insideDi)
                    {
                    }
                    else
                    {
                        result.Add(">  at Microsoft.Extensions.DependencyInjection.Simple.ServiceProvider2.GetService <collapsed>");
                        insideDi = true;
                    }
                }
                else
                {
                    result.Add(frame);
                    insideDi = false;
                }

            }
            return result.Skip(1).ToArray();
        }

        public object GetService(Type serviceType, ResolutionStep step)
        {
            if (serviceType == typeof(IServiceScopeFactory))
            {
                step.Used(Features.IServiceScopeFactory);
                return this;
            }
            if (serviceType == typeof(IServiceProvider))
            {
                step.Used(Features.IServiceProvider);
                return this;
            }
            var desctiptors = _services.Where(t => t.ServiceType == serviceType);
            var descriptor = desctiptors.LastOrDefault(t => t.ServiceType == serviceType);

            List<ServiceDescriptor> openEnumerable = null;
            ServiceDescriptor openGeneric = null;
            if (serviceType.IsConstructedGenericType)
            {

                var genericBase = serviceType.GetGenericTypeDefinition();
                if (genericBase == typeof(IEnumerable<>))
                {
                    var genericAgument = serviceType.GenericTypeArguments[0];
                    openEnumerable = _services.Where(s => s.ServiceType == genericAgument).ToList();
                }
                openGeneric = _services.FirstOrDefault(t => t.ServiceType == genericBase);
            }

            if (descriptor == null)
            {
                if (serviceType.IsConstructedGenericType)
                {
                    if (openEnumerable != null)
                    {
                        step.Used(Features.OpenIEnumerable);
                        var genericAgument = serviceType.GenericTypeArguments[0];
                        if (genericAgument.GetProperty("Order", BindingFlags.Instance | BindingFlags.Public ) == null)
                        {
                            step.Used(Features.IEnumerableNoOrder);
                        }
                        if (!openEnumerable.Any())
                        {
                            step.Used(Features.IEnumerableEmpty);
                        }
                        var a = Array.CreateInstance(genericAgument, openEnumerable.Count());
                        for (int i = 0; i < a.Length; i++)
                        {
                            var ss = step.AddSubstep(openEnumerable[i].ServiceType);
                            a.SetValue(Resolve(openEnumerable[i], ss), i);
                        }
                        step.ResultType = a.GetType();
                        return a;
                    }

                    if (openGeneric != null)
                    {
                        step.Used(Features.Generic);
                        return Resolve(openGeneric, step, serviceType, serviceType.GenericTypeArguments);
                    }
                }
                return null;
            }

            if (desctiptors.Count() > 1)
            {
                step.Used(Features.OrderOverride);
            }
            if (openEnumerable?.Any() == true)
            {
                step.Used(Features.IEnumerableOverride);
            }
            if (openGeneric != null)
            {
                step.Used(Features.GenericOverride);
            }
            return Resolve(descriptor, step);
        }

        private object Resolve(ServiceDescriptor descriptor, ResolutionStep step)
        {
            return Resolve(descriptor, step, descriptor.ServiceType, null);
        }

        private object Resolve(ServiceDescriptor descriptor, ResolutionStep step, Type type, Type[] typeArguments)
        {
            object result;
            switch (descriptor.Lifetime)
            {
                case ServiceLifetime.Singleton:
                    step.Used(Features.Singleton);
                    result = Singleton(Tuple.Create(descriptor, type), () => Create(descriptor, step, typeArguments));
                    break;
                case ServiceLifetime.Scoped:
                    step.Used(Features.Scoped);
                    result = Scoped(Tuple.Create(descriptor, type), () => Create(descriptor, step, typeArguments));
                    break;
                case ServiceLifetime.Transient:
                    step.Used(Features.Transient);
                    result = Transient(Create(descriptor, step, typeArguments));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            step.ResultType = result?.GetType();
            return result;
        }

        private object Scoped(object key, Func<object> func)
        {
            return Scoped(key, func, this);
        }

        private object Create(ServiceDescriptor descriptor, ResolutionStep step, Type[] typeArguments)
        {
            if (descriptor.ImplementationType != null)
            {
                return CreateInstance(step, descriptor.ImplementationType, typeArguments);
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

        private object CreateInstance(ResolutionStep step, Type implementationType, Type[] typeArguments)
        {
            var type = implementationType;
            if (typeArguments != null)
            {
                type = implementationType.MakeGenericType(typeArguments);
            }
            var consctructors = type.GetTypeInfo().DeclaredConstructors
                .Where(c=>!c.IsStatic)
                .OrderByDescending(c=> c.GetParameters().Length);
            List<object> arguments = new List<object>();

            if (consctructors.Count() > 1)
            {
                step.Used(Features.ConstructorSelection);
            }
            foreach (var constructorInfo in consctructors)
            {
                var parameters = constructorInfo.GetParameters();
                arguments.Clear();

                foreach (var parameterInfo in parameters)
                {
                    var value = GetService(parameterInfo.ParameterType, step.AddSubstep(parameterInfo.ParameterType));
                    if (value == null)
                    {
                        break;
                    }
                    arguments.Add(value);
                }

                if (parameters.Length != arguments.Count)
                {
                    continue;
                }
                return Activator.CreateInstance(type, arguments.ToArray());
            }
            throw new InvalidOperationException("Can not find constructor");
        }

        private object Transient(object o)
        {
            _toDispose.Add(o);
            return o;
        }

        private static object Scoped(object key, Func<object> func, DiagnosticServiceProvider provider)
        {
            object instance;
            if (provider._scoped.TryGetValue(key, out instance))
            {
                return instance;
            }
            instance = func();
            provider._scoped.Add(key, instance);
            return instance;
        }

        private object Singleton(object key, Func<object> func)
        {
            return Scoped(key, func, _root);
        }

        public IServiceScope CreateScope()
        {
            return new ServiceScope2(new DiagnosticServiceProvider(this));
        }

        public void Dispose()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                foreach (var o in _toDispose.Concat(_scoped.Values))
                {
                    if (!ReferenceEquals(o, this))
                    {
                        (o as IDisposable)?.Dispose();
                    }
                }
            }

        }
    }
}