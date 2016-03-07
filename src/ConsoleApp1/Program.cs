using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sc = new ServiceCollection();
            sc.AddTransient<IFoo, Foo>();
            sc.AddScoped<IBar, Bar>();
            sc.AddSingleton<IBaz, Baz>();
            var sp = sc.BuildServiceProvider();
            var sb = new StringBuilder();
            sb.AppendLine("public class ConsoleApp1_Services");
            sb.AppendLine("{");
            sb.AppendLine("    public object GetService(ServiceProvider provider, Type serviceType)");
            sb.AppendLine("    {");
            foreach (var st in sc)
            {
                GenerateLookup(sb, st.ServiceType);
            }
            GenerateLookup(sb, typeof(IServiceProvider));
            GenerateLookup(sb, typeof(IServiceScopeFactory));
            sb.AppendLine("        return null;");
            sb.AppendLine("    }");
            sb.AppendLine();
            foreach (var st in sc)
            {
                GenerateServiceBody(sp, sb, st.ServiceType);
            }
            GenerateServiceBody(sp, sb, typeof(IServiceProvider));
            GenerateServiceBody(sp, sb, typeof(IServiceScopeFactory));
            sb.AppendLine("}");
            Console.WriteLine(sb);
        }

        private static void GenerateLookup(StringBuilder sb, Type serviceType)
        {
            var method = $"Get{serviceType.ToString().Replace('.', '_')}";
            sb.AppendLine($"        if (serviceType == typeof({serviceType}))");
            sb.AppendLine("        {");
            sb.AppendLine($"            return {method}(provider);");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void GenerateServiceBody(ServiceProvider sp, StringBuilder sb, Type serviceType)
        {
            var method = $"Get{serviceType.ToString().Replace('.', '_')}";
            sb.AppendLine($"    public {serviceType} {method}(ServiceProvider provider)");
            sb.AppendLine("    {");
            sb.AppendLine($"        return {sp.GetServiceExpression(serviceType, "provider")};");
            sb.AppendLine("    }");
            sb.AppendLine();
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

        public Foo(IBar bar, IBaz z)
        {
            _bar = bar;
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
