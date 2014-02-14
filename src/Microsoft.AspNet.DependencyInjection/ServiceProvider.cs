using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.AspNet.DependencyInjection
{
    /// <summary>
    /// The default IServiceProvider.
    /// </summary>
    public class ServiceProvider : IServiceProvider, IServiceFactoryProvider
    {
        private readonly IDictionary<Type, Func<IServiceProvider, object>> _services = new Dictionary<Type, Func<IServiceProvider, object>>();
        private readonly IDictionary<Type, List<Func<IServiceProvider, object>>> _priorServices = new Dictionary<Type, List<Func<IServiceProvider, object>>>();

        /// <summary>
        /// 
        /// </summary>
        public ServiceProvider()
        {
            // Why do we need to register the IServiceProvider with itself?
            _services[typeof(IServiceProvider)] = _ => this;
        }

        /// <summary>
        /// Gets the service object of the specified type.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public virtual object GetService(Type serviceType)
        {
            Func<IServiceProvider, object> serviceFactory;
            if (TryGetSingleServiceFactory(serviceType, out serviceFactory))
            {
                return serviceFactory(this);
            }

            Func<IServiceProvider, IList> multiServiceFactory;
            if (TryGetMultiServiceFactory(serviceType, out multiServiceFactory))
            {
                return multiServiceFactory(this);
            }

            return null;
        }

        protected bool TryGetSingleServiceFactory(Type serviceType, out Func<IServiceProvider, object> serviceFactory)
        {
            return _services.TryGetValue(serviceType, out serviceFactory);
        }

        bool IServiceFactoryProvider.TryGetSingleServiceFactory(Type serviceType, out Func<IServiceProvider, object> serviceFactory)
        {
            return TryGetSingleServiceFactory(serviceType, out serviceFactory);
        }

        protected bool TryGetMultiServiceFactory(Type collectionType, out Func<IServiceProvider, IList> multiServiceFactory)
        {
            if (collectionType.GetTypeInfo().IsGenericType &&
                collectionType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                var serviceFactories = new List<Func<IServiceProvider, object>>();

                Type serviceType = collectionType.GetTypeInfo().GenericTypeArguments.Single();
                Type listType = typeof(List<>).MakeGenericType(serviceType);

                Func<IServiceProvider, object> serviceFactory;
                if (_services.TryGetValue(serviceType, out serviceFactory))
                {
                    serviceFactories.Add(serviceFactory);

                    List<Func<IServiceProvider, object>> prior;
                    if (_priorServices.TryGetValue(serviceType, out prior))
                    {
                        serviceFactories.AddRange(prior);
                    }
                }

                multiServiceFactory = serviceProvider =>
                {
                    var services = (IList)Activator.CreateInstance(listType);

                    foreach (var factory in serviceFactories)
                    {
                        services.Add(factory(serviceProvider));
                    }

                    return services;
                };

                return true;
            }

            multiServiceFactory = null;
            return false;
        }

        bool IServiceFactoryProvider.TryGetMultiServiceFactory(Type collectionType, out Func<IServiceProvider, IList> multiServiceFactory)
        {
            return TryGetMultiServiceFactory(collectionType, out multiServiceFactory);
        }

        /// <summary>
        /// Remove all occurrences of the given type from the provider.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public virtual ServiceProvider RemoveAll<T>()
        {
            return RemoveAll(typeof(T));
        }

        /// <summary>
        /// Remove all occurrences of the given type from the provider.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public virtual ServiceProvider RemoveAll(Type type)
        {
            _services.Remove(type);
            _priorServices.Remove(type);
            return this;
        }

        /// <summary>
        /// Add an instance of type TService to the list of providers.
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="instance"></param>
        /// <returns></returns>
        public virtual ServiceProvider AddInstance<TService>(object instance)
        {
            return AddInstance(typeof(TService), instance);
        }

        /// <summary>
        /// Add an instance of the given type to the list of providers.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        public virtual ServiceProvider AddInstance(Type service, object instance)
        {
            return Add(service, _ => instance);
        }

        /// <summary>
        /// Specify that services of the type TService should be fulfilled by the type TImplementation.
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        /// <returns></returns>
        public virtual ServiceProvider Add<TService, TImplementation>()
        {
            return Add(typeof(TService), typeof(TImplementation));
        }

        /// <summary>
        /// Specify that services of the type serviceType should be fulfilled by the type implementationType.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="implementationType"></param>
        /// <returns></returns>
        public virtual ServiceProvider Add(Type serviceType, Type implementationType)
        {
            Func<IServiceProvider, object> factory = ActivatorUtilities.CreateFactory(implementationType);
            return Add(serviceType, factory);
        }

        /// <summary>
        /// Specify that services of the given type should be created with the given serviceFactory.
        /// </summary>
        /// <param name="serviceType"></param>
        /// <param name="serviceFactory"></param>
        /// <returns></returns>
        public virtual ServiceProvider Add(Type serviceType, Func<IServiceProvider, object> serviceFactory)
        {
            Func<IServiceProvider, object> existing;
            if (_services.TryGetValue(serviceType, out existing))
            {
                List<Func<IServiceProvider, object>> prior;
                if (_priorServices.TryGetValue(serviceType, out prior))
                {
                    prior.Add(existing);
                }
                else
                {
                    prior = new List<Func<IServiceProvider, object>> { existing };
                    _priorServices.Add(serviceType, prior);
                }
            }
            _services[serviceType] = serviceFactory;
            return this;
        }

        public virtual ServiceProvider Add(IServiceDescriptor serviceDescriptor)
        {
            if (serviceDescriptor.ImplementationType != null)
            {
                return Add(
                    serviceDescriptor.ServiceType,
                    serviceDescriptor.ImplementationType);
            }
            else
            {
                return AddInstance(
                    serviceDescriptor.ServiceType,
                    serviceDescriptor.ImplementationInstance);
            }
        }

        public virtual ServiceProvider Add(params IEnumerable<IServiceDescriptor>[] serviceDescriptors)
        {
            foreach (var descriptor in serviceDescriptors.SelectMany(descriptors => descriptors))
            {
                Add(descriptor);
            }
            return this;
        }
    }
}
