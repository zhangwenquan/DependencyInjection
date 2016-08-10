// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Extensions.DependencyInjection.Abstractions;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionEnumerableExtensions
    {
        public static IServiceCollection2 AddEnumerable<TService>(this IServiceCollection2 services)
            where TService : class
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            AddEnumerable(services, typeof(TService));
            return services;
        }

        public static IServiceCollection2 AddEnumerable(
            this IServiceCollection2 services,
            Type serviceType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            GetEnumerableDescriptor(services, serviceType);
            return services;
        }

        public static IServiceCollection2 AddEnumerable<TService, TImplementation>(this IServiceCollection2 services)
            where TService : class
            where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Transient(typeof(TService), typeof(TImplementation)));
        }

        public static IServiceCollection2 AddEnumerable<TService>(
            this IServiceCollection2 services,
            TService implementationInstance)
            where TService : class
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (implementationInstance == null)
            {
                throw new ArgumentNullException(nameof(implementationInstance));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Singleton(typeof(TService), implementationInstance));
        }

        public static IServiceCollection2 AddEnumerable(
            this IServiceCollection2 services,
            Type serviceType,
            object implementationInstance)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            if (implementationInstance == null)
            {
                throw new ArgumentNullException(nameof(implementationInstance));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Singleton(serviceType, implementationInstance));
        }

        public static IServiceCollection2 AddEnumerable(
            this IServiceCollection2 services,
            Type serviceType,
            Type implementationType)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException(nameof(implementationType));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Transient(serviceType, implementationType));
        }

        public static IServiceCollection2 AddEnumerable(
           this IServiceCollection2 services,
           Type serviceType,
           Func<IServiceProvider, object> implementationFactory)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            if (implementationFactory == null)
            {
                throw new ArgumentNullException(nameof(implementationFactory));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Transient(serviceType, implementationFactory));
        }

        public static IServiceCollection2 AddEnumerable<TService, TImplementation>(
           this IServiceCollection2 services,
           Func<IServiceProvider, TImplementation> implementationFactory)
           where TService : class
           where TImplementation : class, TService
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (implementationFactory == null)
            {
                throw new ArgumentNullException(nameof(implementationFactory));
            }

            return AddEnumerable(services, (ServiceDescriptor2) ServiceDescriptor2.Transient(typeof(TService), implementationFactory));
        }

        public static IServiceCollection2 AddEnumerable(
            this IServiceCollection2 collection,
            ServiceDescriptor2 descriptor)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (descriptor == null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }

            var collectionDescriptor = GetEnumerableDescriptor(collection, descriptor.ServiceType);
            collectionDescriptor.Descriptors.Add(descriptor);
            return collection;
        }

        private static EnumerableServiceDescriptor GetEnumerableDescriptor(
            this IServiceCollection2 collection,
            Type serviceType)
        {
            var descriptor = (EnumerableServiceDescriptor)
                collection.FirstOrDefault(d =>
                    d.GetType() == typeof(EnumerableServiceDescriptor) &&
                    d.ServiceType == serviceType);
            if (descriptor == null)
            {
                descriptor = new EnumerableServiceDescriptor(serviceType);
                collection.Add(descriptor);
            }
            return descriptor;
        }

        /// <summary>
        /// Adds a <see cref="ServiceDescriptor2"/> if an existing descriptor with the same
        /// <see cref="ServiceDescriptor2.ServiceType"/> and an implementation that does not already exist
        /// in <paramref name="services."/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptor">The <see cref="ServiceDescriptor2"/>.</param>
        /// <remarks>
        /// Use <see cref="TryAddEnumerable(IServiceCollection2, ServiceDescriptor2)"/> when registing a service implementation of a
        /// service type that
        /// supports multiple registrations of the same service type. Using
        /// <see cref="ServiceCollectionDescriptorExtensions.Add(IServiceCollection2, ServiceDescriptor2)"/> is not idempotent and can add
        /// duplicate
        /// <see cref="ServiceDescriptor2"/> instances if called twice. Using
        /// <see cref="TryAddEnumerable(IServiceCollection2, ServiceDescriptor2)"/> will prevent registration
        /// of multiple implementation types.
        /// </remarks>
        public static void TryAddEnumerable(
            this IServiceCollection2 services,
            ServiceDescriptor2 descriptor)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (descriptor == null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }

            var enumerableDescriptor = GetEnumerableDescriptor(services, descriptor.ServiceType);
            var implementationType = descriptor.GetImplementationType();

            if (implementationType == typeof(object) ||
                implementationType == descriptor.ServiceType)
            {
                throw new ArgumentException(
                    Resources.FormatTryAddIndistinguishableTypeToEnumerable(
                        implementationType,
                        descriptor.ServiceType),
                    nameof(descriptor));
            }

            if (!enumerableDescriptor.Descriptors.Any(d =>
                              d.ServiceType == descriptor.ServiceType &&
                              d.GetImplementationType() == implementationType))
            {
                enumerableDescriptor.Descriptors.Add(descriptor);
            }
        }

        /// <summary>
        /// Adds the specified <see cref="ServiceDescriptor2"/>s if an existing descriptor with the same
        /// <see cref="ServiceDescriptor2.ServiceType"/> and an implementation that does not already exist
        /// in <paramref name="services."/>.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptors">The <see cref="ServiceDescriptor2"/>s.</param>
        /// <remarks>
        /// Use <see cref="TryAddEnumerable(IServiceCollection2, ServiceDescriptor2)"/> when registing a service
        /// implementation of a service type that
        /// supports multiple registrations of the same service type. Using
        /// <see cref="ServiceCollectionDescriptorExtensions.Add(IServiceCollection2, ServiceDescriptor2)"/> is not idempotent and can add
        /// duplicate
        /// <see cref="ServiceDescriptor2"/> instances if called twice. Using
        /// <see cref="TryAddEnumerable(IServiceCollection2, ServiceDescriptor2)"/> will prevent registration
        /// of multiple implementation types.
        /// </remarks>
        public static void TryAddEnumerable(
            this IServiceCollection2 services,
            IEnumerable<ServiceDescriptor2> descriptors)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (descriptors == null)
            {
                throw new ArgumentNullException(nameof(descriptors));
            }

            foreach (var d in descriptors)
            {
                services.TryAddEnumerable(d);
            }
        }

        internal static Type GetImplementationType(this ServiceDescriptor2 descriptor)
        {
            var factoryServiceDescriptor = descriptor as FactoryServiceDescriptor;
            if (factoryServiceDescriptor != null)
            {
                var typeArguments = factoryServiceDescriptor.ImplementationFactory.GetType().GenericTypeArguments;

                Debug.Assert(typeArguments.Length == 2);

                return typeArguments[1];
            }

            var typeServiceDescriptor = descriptor as TypeServiceDescriptor;
            if (typeServiceDescriptor != null)
            {
                return typeServiceDescriptor.ImplementationType;
            }

            var instanceServiceDescriptor = descriptor as InstanceServiceDescriptor;
            if (instanceServiceDescriptor != null)
            {
                return instanceServiceDescriptor.ImplementationInstance.GetType();
            }

            throw new NotSupportedException($"Unsupported service descriptor type '{descriptor.GetType()}'");
        }
    }
}