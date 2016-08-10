// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection.Abstractions.V2;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class FactoryService : IService, IServiceCallSite
    {
        internal FactoryServiceDescriptor Descriptor { get; }

        public FactoryService(FactoryServiceDescriptor descriptor)
        {
            Descriptor = descriptor;
        }

        public IService Next { get; set; }

        public ServiceLifetime Lifetime
        {
            get { return Descriptor.Lifetime; }
        }

        public Type ServiceType => Descriptor.ServiceType;

        public IServiceCallSite CreateCallSite(ServiceProvider2 provider, ISet<Type> callSiteChain)
        {
            return this;
        }
    }
}
