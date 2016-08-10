// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class ConstructorCallSite : IServiceCallSite
    {
        internal ConstructorInfo ConstructorInfo { get; }
        internal IServiceCallSite[] ParameterCallSites { get; }

        public ConstructorCallSite(ConstructorInfo constructorInfo, IServiceCallSite[] parameterCallSites)
        {
            ConstructorInfo = constructorInfo;
            ParameterCallSites = parameterCallSites;
        }
    }
}
