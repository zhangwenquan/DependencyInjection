using System;

namespace Microsoft.Extensions.DependencyInjection.Simple
{
    internal class ServiceScope : IServiceScope
    {
        private readonly DiagnosticServiceProvider _serviceProvider;

        public ServiceScope(DiagnosticServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Dispose()
        {
            _serviceProvider.Dispose();
        }

        public IServiceProvider ServiceProvider => _serviceProvider;
    }
}