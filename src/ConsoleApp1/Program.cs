using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IFoo, Foo>();
            services.AddScoped<IBar, Bar>();
            services.AddSingleton<IBaz, Baz>();

            var code = services.GenerateCode("MyAppContainer");
            File.WriteAllText("MyAppContainer.cs", code);
            var container = Container.Create(services, typeof(Program).GetTypeInfo().Assembly);
            var foo = container.GetRequiredService<IFoo>();
        }
    }

    public static class CodeGenServiceCollectionExtensions
    {
        public static string GenerateCode(this IServiceCollection services, string typeName)
        {
            var gen = new CodeGenerator(services);
            return gen.GenerateCode(typeName);
        }

        public class CodeGenerator
        {
            private Dictionary<Type, ServiceDescriptor> _services;

            public CodeGenerator(IServiceCollection services)
            {
                _services = new Dictionary<Type, ServiceDescriptor>();
                foreach (var item in services)
                {
                    if (item.ImplementationFactory != null ||
                        item.ImplementationInstance != null ||
                        item.ServiceType.ContainsGenericParameters)
                    {
                        _services[item.ServiceType] = null;
                    }
                    else
                    {
                        _services[item.ServiceType] = item;

                    }
                }
            }

            private void GenerateLookup(StringBuilder sb, Type serviceType)
            {
                string method = GetMethodName(serviceType);
                sb.AppendLine($"        if (serviceType == typeof({serviceType}))");
                sb.AppendLine("        {");
                sb.AppendLine($"            return {method}();");
                sb.AppendLine("        }");
                sb.AppendLine();
            }

            private void GenerateServiceBody(StringBuilder sb, ServiceDescriptor descriptor)
            {
                var serviceType = descriptor.ServiceType;
                string method = GetMethodName(serviceType);
                sb.AppendLine($"    public {serviceType} {method}()");
                sb.AppendLine("    {");
                sb.AppendLine($"        return {GenerateCreateInstance(descriptor)};");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            private string GenerateCreateInstance(ServiceDescriptor descriptor)
            {
                var constructors = descriptor.ImplementationType.GetTypeInfo()
                                .DeclaredConstructors
                                .Where(constructor => constructor.IsPublic)
                                .ToArray();

                if (constructors.Length == 0)
                {
                    return $"new {descriptor.ImplementationType}()";
                }

                ConstructorInfo ctor = null;
                if (constructors.Length == 1)
                {
                    ctor = constructors[0];
                }
                else
                {
                    ctor = constructors.OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
                }

                var sb = new StringBuilder();
                sb.Append($"new {descriptor.ImplementationType}(");
                bool first = true;
                foreach (var param in ctor.GetParameters())
                {
                    if (!first)
                    {
                        sb.Append(", ");
                    }
                    sb.Append($"Resolve<{param.ParameterType}>()");
                    first = false;
                }
                sb.Append(")");
                return sb.ToString();
            }

            private string GetMethodName(Type serviceType)
            {
                if (_services.ContainsKey(serviceType))
                {
                    return $"Get{serviceType.ToString().Replace('.', '_')}";
                }
                throw new NotSupportedException();
            }

            internal string GenerateCode(string typeName)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"public class {typeName} : {typeof(Container)}");
                sb.AppendLine("{");
                sb.AppendLine($"    public {typeName}()");
                sb.AppendLine("    {");
                sb.AppendLine("    }");
                sb.AppendLine();
                sb.AppendLine($"    public {typeName}({typeof(Container)} container) : base(container)");
                sb.AppendLine("    {");
                sb.AppendLine("    }");
                sb.AppendLine();
                sb.AppendLine($"    protected override object GetService({typeof(Type)} serviceType)");
                sb.AppendLine("    {");
                foreach (var item in _services)
                {
                    if (item.Value == null) continue;
                    GenerateLookup(sb, item.Value.ServiceType);
                }
                sb.AppendLine("        return base.GetService(serviceType);");
                sb.AppendLine("    }");
                sb.AppendLine();
                foreach (var item in _services)
                {
                    if (item.Value == null) continue;
                    GenerateServiceBody(sb, item.Value);
                }

                sb.AppendLine($"    protected override void Populate({typeof(IServiceCollection)} services)");
                sb.AppendLine("    {");
                foreach (var item in _services)
                {
                    if (item.Value == null) continue;
                    sb.AppendLine($"        services.Add(new {typeof(ServiceDescriptor)}(typeof({item.Key}), _ => {GetMethodName(item.Key)}(), {typeof(ServiceLifetime)}.{item.Value.Lifetime}));");
                }
                sb.AppendLine("    }");
                sb.AppendLine();

                sb.AppendLine("}");
                return sb.ToString();
            }
        }
    }

    public abstract class Container : IDisposable, IServiceProvider, IServiceScopeFactory
    {
        private readonly Dictionary<Type, object> _instances = new Dictionary<Type, object>();
        private readonly List<IDisposable> _transients = new List<IDisposable>();
        private readonly Dictionary<Type, ServiceDescriptor> _services = new Dictionary<Type, ServiceDescriptor>();

        private bool _disposed;
        private Container _root;

        public Container()
        {
            _root = this;
        }

        public Container(Container root)
        {
            _root = root;
        }

        protected virtual void Populate(IServiceCollection services)
        {

        }

        protected virtual object GetService(Type type)
        {
            if (type == typeof(IServiceProvider) || type == typeof(IServiceScopeFactory))
            {
                return this;
            }

            var result = Resolve(type);
            if (result != null)
            {
                return result;
            }

            return null;
        }

        object IServiceProvider.GetService(Type type) => GetService(type);

        protected T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        protected T Fail<T>()
        {
            throw new Exception($"Unable to resolve {typeof(T)}");
        }

        private object Resolve(Type type)
        {
            ServiceDescriptor descriptor;
            if (_services.TryGetValue(type, out descriptor))
            {
                if (descriptor.ImplementationType != null)
                {
                    if (descriptor.ImplementationType.ContainsGenericParameters)
                    {
                        throw new NotSupportedException();
                    }

                    var constructors = descriptor.ImplementationType.GetTypeInfo()
                                .DeclaredConstructors
                                .Where(constructor => constructor.IsPublic)
                                .ToArray();

                    if (constructors.Length == 0)
                    {
                        return $"new {descriptor.ImplementationType}()";
                    }

                    ConstructorInfo ctor = null;
                    if (constructors.Length == 1)
                    {
                        ctor = constructors[0];
                    }
                    else
                    {
                        ctor = constructors.OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
                    }

                    var parameters = ctor.GetParameters();
                    var args = new object[parameters.Length];
                    for (int i = 0; i < args.Length; i++)
                    {
                        args[i] = Resolve(parameters[i].ParameterType);
                    }

                    switch (descriptor.Lifetime)
                    {
                        case ServiceLifetime.Singleton:
                            return Singleton(type, () => ctor.Invoke(args));
                        case ServiceLifetime.Scoped:
                            return Scoped(type, () => ctor.Invoke(args));
                        case ServiceLifetime.Transient:
                            return Transient(ctor.Invoke(args));
                    }
                }

                if (descriptor.ImplementationInstance != null)
                {
                    return descriptor.ImplementationInstance;
                }

                if (descriptor.ImplementationFactory != null)
                {
                    switch (descriptor.Lifetime)
                    {
                        case ServiceLifetime.Singleton:
                            return Singleton(type, () => descriptor.ImplementationFactory(this));
                        case ServiceLifetime.Scoped:
                            return Scoped(type, () => descriptor.ImplementationFactory(this));
                        case ServiceLifetime.Transient:
                            return Transient(descriptor.ImplementationFactory(this));
                    }
                }
            }
            return null;
        }

        private object Singleton(Type type, Func<object> factory)
        {
            return _root.Scoped(type, factory);
        }

        private object Transient(object service)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            var disposable = service as IDisposable;
            if (disposable != null)
            {
                lock (_transients)
                {
                    _transients.Add(disposable);
                }
            }

            return service;
        }

        private object Scoped(Type type, Func<object> factory)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().FullName);
            }

            object scoped;
            lock (_instances)
            {
                if (!_instances.TryGetValue(type, out scoped))
                {
                    scoped = factory();
                    _instances[type] = scoped;
                }
            }
            return scoped;
        }

        public void Dispose()
        {
            lock (_instances)
            {
                foreach (var resolved in _instances)
                {
                    (resolved.Value as IDisposable)?.Dispose();
                }
            }

            lock (_transients)
            {
                _transients.ForEach(t => t.Dispose());
                _transients.Clear();
            }
        }

        IServiceScope IServiceScopeFactory.CreateScope()
        {
            var container = Activator.CreateInstance(GetType(), this);
            return new ServiceScope((Container)container);
        }

        public static Container Create(IServiceCollection services, Assembly assembly)
        {
            var type = assembly.GetTypes().FirstOrDefault(t => t.BaseType == typeof(Container));
            if (type == null)
            {
                return null;
            }
            var container = Activator.CreateInstance(type) as Container;

            var containerServices = new ServiceCollection();
            container.Populate(containerServices);

            foreach (var service in services)
            {
                container._services[service.ServiceType] = service;
            }

            foreach (var service in containerServices)
            {
                container._services[service.ServiceType] = service;
            }

            return container;
        }

        private class ServiceScope : IServiceScope
        {
            public ServiceScope(Container container)
            {
                ServiceProvider = container;
            }

            public IServiceProvider ServiceProvider { get; }

            public void Dispose()
            {
                ((Container)ServiceProvider).Dispose();
            }
        }
    }


    public interface IFoo
    {

    }

    public interface IBar
    {

    }

    public interface IBaz
    {

    }

    public class Foo : IFoo
    {
        private readonly IBar _bar;
        private readonly IBaz _baz;

        public Foo(IBar bar, IBaz z)
        {
            _bar = bar;
            _baz = z;
        }
    }

    public class Bar : IBar
    {
        public Bar(IBaz z)
        {

        }
    }

    public class Baz : IBaz
    {

    }
}
