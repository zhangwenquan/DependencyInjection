using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection.Specification;

namespace Microsoft.Extensions.DependencyInjection.Simple.Tests
{
    public class ServiceProviderContainerTests : DependencyInjectionSpecificationTests
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection collection) =>
            new ServiceProvider(collection);
    }
}
