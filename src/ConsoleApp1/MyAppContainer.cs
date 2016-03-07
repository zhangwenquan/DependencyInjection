using System.Linq.Expressions;

public class MyAppContainer
{
    public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyInjection.ServiceLookup.IService> GetServices()
    {
        yield return new ConsoleApp1_IFooService();
        yield return new ConsoleApp1_IBarService();
    }

    private class ConsoleApp1_IFooService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _bar;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _z;
        public System.Type ServiceType => typeof(ConsoleApp1.IFoo);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            _bar = provider.GetServiceCallSite(typeof(ConsoleApp1.IBar), callSiteChain);
            _z = provider.GetServiceCallSite(typeof(ConsoleApp1.IBaz), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new ConsoleApp1.Foo((ConsoleApp1.IBar)_bar.Invoke(provider), (ConsoleApp1.IBaz)_z.Invoke(provider));
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return provider;
        }
    }

    private class ConsoleApp1_IBarService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _z;
        public System.Type ServiceType => typeof(ConsoleApp1.IBar);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            _z = provider.GetServiceCallSite(typeof(ConsoleApp1.IBaz), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new ConsoleApp1.Bar((ConsoleApp1.IBaz)_z.Invoke(provider));
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return provider;
        }
    }

}
