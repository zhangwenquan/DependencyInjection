// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection.Abstractions;

namespace Microsoft.Extensions.DependencyInjection.Extensions
{
    public static class ServiceCollectionDescriptorExtensions
    {
        /// <summary>
        /// Adds the specified <paramref name="descriptor"/> to the <paramref name="collection"/>.
        /// </summary>
        /// <param name="collection">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptor">The <see cref="ServiceDescriptor2"/>.</param>
        /// <returns>A reference to the current instance of <see cref="IServiceCollection2"/>.</returns>
        public static IServiceCollection2 Add(
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
            collection.Add(descriptor);
            return collection;
        }

        /// <summary>
        /// Adds a sequence of <see cref="ServiceDescriptor2"/> to the <paramref name="collection"/>.
        /// </summary>
        /// <param name="collection">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptors">The <see cref="IEnumerable{T}"/> of <see cref="ServiceDescriptor2"/>s to add.</param>
        /// <returns>A reference to the current instance of <see cref="IServiceCollection2"/>.</returns>
        public static IServiceCollection2 Add(
            this IServiceCollection2 collection,
            IEnumerable<ServiceDescriptor2> descriptors)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (descriptors == null)
            {
                throw new ArgumentNullException(nameof(descriptors));
            }

            foreach (var descriptor in descriptors)
            {
                collection.Add(descriptor);
            }

            return collection;
        }

        /// <summary>
        /// Adds the specified <paramref name="descriptor"/> to the <paramref name="collection"/> if the
        /// service type hasn't been already registered.
        /// </summary>
        /// <param name="collection">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptor">The <see cref="ServiceDescriptor2"/>.</param>
        public static void TryAdd(
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

            if (!collection.Any(d => d.ServiceType == descriptor.ServiceType))
            {
                collection.Add(descriptor);
            }
        }

        /// <summary>
        /// Adds the specified <paramref name="descriptors"/> to the <paramref name="collection"/> if the
        /// service type hasn't been already registered.
        /// </summary>
        /// <param name="collection">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptors">The <see cref="ServiceDescriptor2"/>s.</param>
        public static void TryAdd(
            this IServiceCollection2 collection,
            IEnumerable<ServiceDescriptor2> descriptors)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (descriptors == null)
            {
                throw new ArgumentNullException(nameof(descriptors));
            }

            foreach (var d in descriptors)
            {
                collection.TryAdd(d);
            }
        }

        public static void TryAddTransient(
            this IServiceCollection2 collection,
            Type service)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            var descriptor = ServiceDescriptor2.Transient(service, service);
            TryAdd(collection, descriptor);
        }

        public static void TryAddTransient(
            this IServiceCollection2 collection,
            Type service,
            Type implementationType)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException(nameof(implementationType));
            }

            var descriptor = ServiceDescriptor2.Transient(service, implementationType);
            TryAdd(collection, descriptor);
        }

        public static void TryAddTransient(
            this IServiceCollection2 collection,
            Type service,
            Func<IServiceProvider, object> implementationFactory)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationFactory == null)
            {
                throw new ArgumentNullException(nameof(implementationFactory));
            }

            var descriptor = ServiceDescriptor2.Transient(service, implementationFactory);
            TryAdd(collection, descriptor);
        }

        public static void TryAddTransient<TService>(this IServiceCollection2 collection)
            where TService : class
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddTransient(collection, typeof(TService), typeof(TService));
        }

        public static void TryAddTransient<TService, TImplementation>(this IServiceCollection2 collection)
            where TService : class
            where TImplementation : class, TService
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddTransient(collection, typeof(TService), typeof(TImplementation));
        }

        public static void TryAddTransient<TService>(
            this IServiceCollection2 services,
            Func<IServiceProvider, TService> implementationFactory)
            where TService : class
        {
            services.TryAdd(ServiceDescriptor2.Transient(implementationFactory));
        }

        public static void TryAddScoped(
            this IServiceCollection2 collection,
            Type service)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            var descriptor = ServiceDescriptor2.Scoped(service, service);
            TryAdd(collection, descriptor);
        }

        public static void TryAddScoped(
            this IServiceCollection2 collection,
            Type service,
            Type implementationType)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException(nameof(implementationType));
            }

            var descriptor = ServiceDescriptor2.Scoped(service, implementationType);
            TryAdd(collection, descriptor);
        }

        public static void TryAddScoped(
            this IServiceCollection2 collection,
            Type service,
            Func<IServiceProvider, object> implementationFactory)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationFactory == null)
            {
                throw new ArgumentNullException(nameof(implementationFactory));
            }

            var descriptor = ServiceDescriptor2.Scoped(service, implementationFactory);
            TryAdd(collection, descriptor);
        }

        public static void TryAddScoped<TService>(this IServiceCollection2 collection)
            where TService : class
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddScoped(collection, typeof(TService), typeof(TService));
        }

        public static void TryAddScoped<TService, TImplementation>(this IServiceCollection2 collection)
            where TService : class
            where TImplementation : class, TService
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddScoped(collection, typeof(TService), typeof(TImplementation));
        }

        public static void TryAddScoped<TService>(
            this IServiceCollection2 services,
            Func<IServiceProvider, TService> implementationFactory)
            where TService : class
        {
            services.TryAdd(ServiceDescriptor2.Scoped(implementationFactory));
        }

        public static void TryAddSingleton(
            this IServiceCollection2 collection,
            Type service)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            var descriptor = ServiceDescriptor2.Singleton(service, service);
            TryAdd(collection, descriptor);
        }

        public static void TryAddSingleton(
            this IServiceCollection2 collection,
            Type service,
            Type implementationType)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationType == null)
            {
                throw new ArgumentNullException(nameof(implementationType));
            }

            var descriptor = ServiceDescriptor2.Singleton(service, implementationType);
            TryAdd(collection, descriptor);
        }

        public static void TryAddSingleton(
            this IServiceCollection2 collection,
            Type service,
            Func<IServiceProvider, object> implementationFactory)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            if (implementationFactory == null)
            {
                throw new ArgumentNullException(nameof(implementationFactory));
            }

            var descriptor = ServiceDescriptor2.Singleton(service, implementationFactory);
            TryAdd(collection, descriptor);
        }

        public static void TryAddSingleton<TService>(this IServiceCollection2 collection)
            where TService : class
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddSingleton(collection, typeof(TService), typeof(TService));
        }

        public static void TryAddSingleton<TService, TImplementation>(this IServiceCollection2 collection)
            where TService : class
            where TImplementation : class, TService
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            TryAddSingleton(collection, typeof(TService), typeof(TImplementation));
        }

        public static void TryAddSingleton<TService>(this IServiceCollection2 collection, TService instance)
            where TService : class
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (instance == null)
            {
                throw new ArgumentNullException(nameof(instance));
            }

            var descriptor = ServiceDescriptor2.Singleton(typeof(TService), instance);
            TryAdd(collection, descriptor);
        }

        public static void TryAddSingleton<TService>(
            this IServiceCollection2 services,
            Func<IServiceProvider, TService> implementationFactory)
            where TService : class
        {
            services.TryAdd(ServiceDescriptor2.Singleton(implementationFactory));
        }

        /// <summary>
        /// Removes the first service in <see cref="IServiceCollection2"/> with the same service type
        /// as <paramref name="descriptor"/> and adds <paramef name="descriptor"/> to the collection.
        /// </summary>
        /// <param name="collection">The <see cref="IServiceCollection2"/>.</param>
        /// <param name="descriptor">The <see cref="ServiceDescriptor2"/> to replace with.</param>
        /// <returns></returns>
        public static IServiceCollection2 Replace(
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

            var registeredServiceDescriptor = collection.FirstOrDefault(s => s.ServiceType == descriptor.ServiceType);
            if (registeredServiceDescriptor != null)
            {
                collection.Remove(registeredServiceDescriptor);
            }

            collection.Add(descriptor);
            return collection;
        }
    }
}
