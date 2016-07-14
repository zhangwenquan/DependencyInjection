using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    public class ServiceProvider: IServiceProvider
    {
        private readonly ServiceDescriptor[] _services;

        public ServiceProvider(IEnumerable<ServiceDescriptor> services)
        {
            _services = services.ToArray();
        }

        public object GetService(Type serviceType)
        {
            _services.Where()
        }

        private void 
    }
}
