// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static ServiceProvider BuildServiceProvider(this IServiceCollection services, IEnumerable<IService> builtServices = null)
        {
            return new ServiceProvider(services, builtServices);
        }
    }
}
