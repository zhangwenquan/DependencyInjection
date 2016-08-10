// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection.Abstractions.V2;

namespace Microsoft.Extensions.DependencyInjection.Ordered
{
    public class OrderedEnumerableServiceDescriptor : ServiceDescriptor2
    {
        public OrderedEnumerableServiceDescriptor(Type serviceType) : base(serviceType, ServiceLifetime.Transient)
        {
        }

        public IList<ServiceDescriptor2> Descriptors { get; } = new List<ServiceDescriptor2>();
    }
}