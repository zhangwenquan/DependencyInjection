using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    public class ResolutionStep
    {
        [JsonConverter(typeof(TypePrettyNameConverter))]
        public Type ServiceType { get; }
        [JsonConverter(typeof(TypePrettyNameConverter))]
        public Type ResultType { get; set; }

        public List<Features> Features { get; } = new List<Features>();
        public List<ResolutionStep> ResolutionSteps { get; } = new List<ResolutionStep>();
        public string[] StackTrace { get; set; }

        public ResolutionStep(Type serviceType)
        {
            ServiceType = serviceType;
        }

        public void Used(Features feature)
        {
            Features.Add(feature);
        }

        public ResolutionStep AddSubstep(Type serviceType)
        {
            var step = new ResolutionStep(serviceType);
            ResolutionSteps.Add(step);
            return step;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, this, 0);
            return sb.ToString();
        }

        static void Print(StringBuilder builder, ResolutionStep step, int ident)
        {
            var pad = new string(' ', ident * 3);
            builder.Append(pad);
            builder.AppendLine($"{PrettyTypeName(step.ServiceType)}->{PrettyTypeName(step.ResultType)} [{string.Join(",", step.Features)}]");
            if (step.StackTrace != null)
            {
                foreach (var line in step.StackTrace)
                {
                    builder.AppendLine(line);
                }
            }
            foreach (var s in step.ResolutionSteps)
            {
                Print(builder, s, ident + 1);
            }
        }

        internal static string PrettyTypeName(Type t)
        {
            if (t == null) return "<null>";
            if (t.IsArray)
            {
                return PrettyTypeName(t.GetElementType()) + "[]";
            }
            if (t.IsConstructedGenericType)
            {
                return string.Format(
                    "{0}<{1}>",
                    t.Name.Substring(0, t.Name.LastIndexOf("`")),
                    string.Join(", ", t.GenericTypeArguments.Select(PrettyTypeName)));
            }

            return t.Name;
        }
    }
    public class TypePrettyNameConverter: JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(ResolutionStep.PrettyTypeName((Type)value));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Type);
        }
    }
}
