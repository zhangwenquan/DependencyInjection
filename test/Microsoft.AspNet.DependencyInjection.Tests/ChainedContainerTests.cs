using System;
using Microsoft.AspNet.DependencyInjection.Tests.Fakes;
using Xunit;

namespace Microsoft.AspNet.DependencyInjection.Tests
{
    public class ChainedContainerTests : AllContainerTestsBase
    {
        protected override IServiceProvider CreateContainer()
        {
            return new ChainedServiceProvider(new ServiceProvider().Add(TestServices.DefaultServices()));
        }

        [Fact]
        public void InnerServiceCanBeReplaced()
        {
            var container = (ChainedServiceProvider)CreateContainer();

            container.Add(typeof(IFakeService), typeof(AlternateFakeService));

            var service = container.GetService<IFakeOuterService>();

            string singleValue;
            string[] multipleValues;
            service.Interrogate(out singleValue, out multipleValues);

            Assert.NotNull(service);
            Assert.Equal(2, multipleValues.Length);
            Assert.Contains("AlternateFakeServiceSimpleMethod", singleValue);
            Assert.Contains("FakeOneMultipleServiceAnotherMethod", multipleValues);
            Assert.Contains("FakeTwoMultipleServiceAnotherMethod", multipleValues);
        }
    }
}
