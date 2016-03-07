public class MyAppContainer : ConsoleApp1.Container
{
    public MyAppContainer()
    {
    }

    public MyAppContainer(ConsoleApp1.Container container) : base(container)
    {
    }

    protected override object GetService(System.Type serviceType)
    {
        if (serviceType == typeof(ConsoleApp1.IFoo))
        {
            return GetConsoleApp1_IFoo();
        }

        if (serviceType == typeof(ConsoleApp1.IBar))
        {
            return GetConsoleApp1_IBar();
        }

        if (serviceType == typeof(ConsoleApp1.IBaz))
        {
            return GetConsoleApp1_IBaz();
        }

        return base.GetService(serviceType);
    }

    public ConsoleApp1.IFoo GetConsoleApp1_IFoo()
    {
        return new ConsoleApp1.Foo(Resolve<ConsoleApp1.IBar>(), Resolve<ConsoleApp1.IBaz>());
    }

    public ConsoleApp1.IBar GetConsoleApp1_IBar()
    {
        return new ConsoleApp1.Bar(Resolve<ConsoleApp1.IBaz>());
    }

    public ConsoleApp1.IBaz GetConsoleApp1_IBaz()
    {
        return new ConsoleApp1.Baz();
    }

    protected override void Populate(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
    {
        services.Add(new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(typeof(ConsoleApp1.IFoo), _ => GetConsoleApp1_IFoo(), Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient));
        services.Add(new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(typeof(ConsoleApp1.IBar), _ => GetConsoleApp1_IBar(), Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped));
        services.Add(new Microsoft.Extensions.DependencyInjection.ServiceDescriptor(typeof(ConsoleApp1.IBaz), _ => GetConsoleApp1_IBaz(), Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton));
    }

}
