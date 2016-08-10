// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection.Abstractions.V2;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class GenericService : IGenericService
    {
        private readonly TypeServiceDescriptor _descriptor;

        public GenericService(TypeServiceDescriptor descriptor)
        {
            _descriptor = descriptor;
        }

        public ServiceLifetime Lifetime
        {
            get { return _descriptor.Lifetime; }
        }

        public IService GetService(Type closedServiceType)
        {
            Type[] genericArguments = closedServiceType.GetTypeInfo().GenericTypeArguments;
            Type closedImplementationType =
                _descriptor.ImplementationType.MakeGenericType(genericArguments);

            var closedServiceDescriptor = new TypeServiceDescriptor(closedServiceType, closedImplementationType, Lifetime);
            return new Service(closedServiceDescriptor);
        }
    }
}
