using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Microsoft.Extensions.Internal;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMvc();

            var code = services.GenerateCode("MyAppContainer");
            File.WriteAllText("MyAppContainer.cs", code);

            // var container = services.BuildServiceProvider(MyAppContainer.GetServices());
            // var foo = container.GetRequiredService<IFoo>();
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
                        item.ServiceType.IsGenericTypeDefinition)
                    {
                        _services[item.ServiceType] = null;
                    }
                    else
                    {
                        _services[item.ServiceType] = item;

                    }
                }
            }

            private void GenerateServiceBody(StringBuilder sb, ServiceDescriptor descriptor)
            {
                var serviceType = descriptor.ServiceType;
                string method = GetClassName(serviceType);
                var constructors = descriptor.ImplementationType.GetTypeInfo()
                                .DeclaredConstructors
                                .Where(constructor => constructor.IsPublic)
                                .ToArray();

                ConstructorInfo ctor = null;
                if (constructors.Length == 1)
                {
                    ctor = constructors[0];
                }
                else if (constructors.Length > 1)
                {
                    ctor = constructors.OrderByDescending(c => c.GetParameters().Length).FirstOrDefault();
                }

                var parameters = ctor?.GetParameters() ?? new ParameterInfo[0];

                sb.AppendLine($"    private class {method} : {typeof(IService)}, {typeof(IServiceCallSite)}");
                sb.AppendLine("    {");
                sb.AppendLine($"        private {typeof(ConstructorInfo)} _ctor;");
                foreach (var parameter in parameters)
                {
                    sb.AppendLine($"        private {typeof(IServiceCallSite)} _{parameter.Name};");
                }
                sb.AppendLine($"        public {typeof(Type)} ServiceType => typeof({GetTypeName(serviceType)});");
                sb.AppendLine($"        public {typeof(IService)} Next {{ get; set; }}");
                sb.AppendLine($"        public {typeof(ServiceLifetime)} Lifetime => {typeof(ServiceLifetime)}.{descriptor.Lifetime};");
                sb.AppendLine($"        public {typeof(IServiceCallSite)} CreateCallSite({typeof(ServiceProvider)} provider, {typeof(ISet<>).ToString().Replace("`1[T]", $"<{typeof(Type)}>")} callSiteChain)");
                sb.AppendLine("        {");
                if (parameters.Length == 0)
                {
                    sb.AppendLine($"            var types = {typeof(Type)}.EmptyTypes;");
                }
                else
                {
                    sb.AppendLine($"            var types = new {typeof(Type)}[{parameters.Length}];");
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        sb.AppendLine($"            types[{i}] = typeof({GetTypeName(parameters[i].ParameterType)});");
                    }
                }

                sb.AppendLine($"            _ctor = {typeof(IntrospectionExtensions)}.GetTypeInfo(typeof({descriptor.ImplementationType})).GetConstructor(types);");
                foreach (var parameter in parameters)
                {
                    sb.AppendLine($"            _{parameter.Name} = provider.GetServiceCallSite(typeof({GetTypeName(parameter.ParameterType)}), callSiteChain);");
                }
                sb.AppendLine("            return this;");
                sb.AppendLine("        }");
                sb.AppendLine($"        public object Invoke({typeof(ServiceProvider)} provider)");
                sb.AppendLine("        {");
                sb.AppendLine($"{GenerateCreateInstance(ctor, descriptor)};");
                sb.AppendLine("        }");
                sb.AppendLine();
                sb.AppendLine($"        public {typeof(Expression)} Build({typeof(Expression)} provider)");
                sb.AppendLine("        {");
                sb.AppendLine($"{GenerateCreateInstanceExpression(ctor, descriptor)};");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            private string GenerateCreateInstance(ConstructorInfo ctor, ServiceDescriptor descriptor)
            {
                if (ctor == null || ctor.GetParameters().Length == 0)
                {
                    return $"            return new {descriptor.ImplementationType}()";
                }

                var sb = new StringBuilder();
                foreach (var param in ctor.GetParameters())
                {
                    sb.AppendLine($"            var {param.Name} = ({GetTypeName(param.ParameterType)})_{param.Name}.Invoke(provider);");
                }

                sb.Append($"            return new {descriptor.ImplementationType}(");
                bool first = true;
                foreach (var param in ctor.GetParameters())
                {
                    if (!first)
                    {
                        sb.Append(", ");
                    }
                    sb.Append(param.Name);
                    first = false;
                }
                sb.Append(")");
                return sb.ToString();
            }

            private string GenerateCreateInstanceExpression(ConstructorInfo ctor, ServiceDescriptor descriptor)
            {
                if (ctor == null || ctor.GetParameters().Length == 0)
                {
                    return $"            return {typeof(Expression)}.New(typeof({descriptor.ImplementationType}))";
                }

                var sb = new StringBuilder();
                foreach (var param in ctor.GetParameters())
                {
                    sb.AppendLine($"            var {param.Name} = _{param.Name}.Build(provider);");
                }
                sb.Append($"            return {typeof(Expression)}.New(_ctor");
                foreach (var param in ctor.GetParameters())
                {
                    sb.Append(", ");
                    sb.Append(param.Name);
                }
                sb.Append(")");
                return sb.ToString();
            }

            private string GetTypeName(Type type)
            {
                return TypeNameHelper.GetTypeDisplayName(type);
            }

            private string GetClassName(Type serviceType)
            {
                if (_services.ContainsKey(serviceType))
                {
                    return $"{serviceType.ToString().Replace('.', '_').Replace('`', '_').Replace('[', '_').Replace("]", "")}Service";
                }
                throw new NotSupportedException();
            }

            internal string GenerateCode(string typeName)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"public class {typeName}");
                sb.AppendLine("{");
                sb.AppendLine($"    public static {typeof(IEnumerable<>).ToString().Replace("`1[T]", $"<{typeof(IService)}>")} GetServices()");
                sb.AppendLine("    {");
                foreach (var item in _services)
                {
                    if (item.Value == null) continue;
                    sb.AppendLine($"        yield return new {GetClassName(item.Key)}();");
                }
                sb.AppendLine("    }");
                sb.AppendLine();
                foreach (var item in _services)
                {
                    if (item.Value == null) continue;
                    GenerateServiceBody(sb, item.Value);
                }
                sb.AppendLine("}");
                return sb.ToString();
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
