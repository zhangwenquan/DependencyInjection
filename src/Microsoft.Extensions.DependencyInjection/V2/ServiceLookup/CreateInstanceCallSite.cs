// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection.Abstractions.V2;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class CreateInstanceCallSite : IServiceCallSite
    {
        internal TypeServiceDescriptor Descriptor { get; }

        public CreateInstanceCallSite(TypeServiceDescriptor descriptor)
        {
            Descriptor = descriptor;
        }
    }
}
