using System;
using System.Collections;

namespace Microsoft.AspNet.DependencyInjection
{
    public interface IServiceFactoryProvider
    {    
        bool TryGetSingleServiceFactory(Type serviceType, out Func<IServiceProvider, object> serviceFactory);

        bool TryGetMultiServiceFactory(Type collectionType, out Func<IServiceProvider, IList> multiServiceFactory);
    }
}
