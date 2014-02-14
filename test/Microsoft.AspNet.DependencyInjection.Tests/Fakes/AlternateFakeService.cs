namespace Microsoft.AspNet.DependencyInjection.Tests.Fakes
{
    public class AlternateFakeService : IFakeService
    {
        public string SimpleMethod()
        {
            return "AlternateFakeServiceSimpleMethod";
        }
    }
}
