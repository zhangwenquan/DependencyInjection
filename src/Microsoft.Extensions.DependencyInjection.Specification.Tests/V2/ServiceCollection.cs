// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection.Abstractions.V2;

namespace Microsoft.Extensions.DependencyInjection.Specification.Tests.V2
{
    internal class ServiceCollection : List<ServiceDescriptor2>, IServiceCollection2
    {
    }
}
