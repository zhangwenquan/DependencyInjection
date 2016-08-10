// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection.Abstractions.V2
{
    public class EnumerableServiceDescriptor : ServiceDescriptor2
    {
        public EnumerableServiceDescriptor(Type serviceType) : base(serviceType, ServiceLifetime.Transient)
        {
        }

        public IList<ServiceDescriptor2> Descriptors { get; } = new List<ServiceDescriptor2>();
    }
}