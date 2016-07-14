using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Features
    {
        IServiceScopeFactory,
        IServiceProvider,
        ConstructorSelection,
        Disposable,
        OpenIEnumerable,
        Generic,
        OrderOverride,
        IEnumerableNoOrder,
        GenericOverride,
        IEnumerableOverride,
        IEnumerableEmpty,
        Singleton,
        Scoped,
        Inception,
        Transient
    }
}