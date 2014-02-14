using System;
using System.Collections;

namespace Microsoft.AspNet.DependencyInjection
{
    public class ChainedServiceProvider : ServiceProvider
    {
        public IServiceFactoryProvider _innerServiceProvider;

        public ChainedServiceProvider(IServiceFactoryProvider innerServiceProvider)
            : base()
        {
            _innerServiceProvider = innerServiceProvider;
        }

        public override object GetService(Type serviceType)
        {
            Func<IServiceProvider, object> serviceFactory;

            if (TryGetSingleServiceFactory(serviceType, out serviceFactory))
            {
                return serviceFactory(this);
            }

            if (_innerServiceProvider.TryGetSingleServiceFactory(serviceType, out serviceFactory))
            {
                return serviceFactory(this);
            }

            Func<IServiceProvider, IList> multiServiceFactory;

            // If TryGetMultiServiceFactory returns false, serviceType does not represent an IEnumerable
            if (TryGetMultiServiceFactory(serviceType, out multiServiceFactory))
            {
                IList allMatchingServices = multiServiceFactory(this);

                if (_innerServiceProvider.TryGetMultiServiceFactory(serviceType, out multiServiceFactory))
                {
                    foreach (var service in multiServiceFactory(this))
                    {
                        allMatchingServices.Add(service);
                    }
                }

                return allMatchingServices;
            }

            return null;
        }

    }
}
