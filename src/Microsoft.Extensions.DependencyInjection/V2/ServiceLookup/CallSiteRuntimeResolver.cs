using System;
using System.Runtime.ExceptionServices;

namespace Microsoft.Extensions.DependencyInjection.V2.ServiceLookup
{
    internal class CallSiteRuntimeResolver : CallSiteVisitor<ServiceProvider2, object>
    {
        public object Resolve(IServiceCallSite callSite, ServiceProvider2 provider)
        {
            return VisitCallSite(callSite, provider);
        }

        protected override object VisitTransient(TransientCallSite transientCallSite, ServiceProvider2 provider)
        {
            return provider.CaptureDisposable(
                VisitCallSite(transientCallSite.Service, provider));
        }

        protected override object VisitConstructor(ConstructorCallSite constructorCallSite, ServiceProvider2 provider)
        {
            object[] parameterValues = new object[constructorCallSite.ParameterCallSites.Length];
            for (var index = 0; index < parameterValues.Length; index++)
            {
                parameterValues[index] = VisitCallSite(constructorCallSite.ParameterCallSites[index], provider);
            }

            try
            {
                return constructorCallSite.ConstructorInfo.Invoke(parameterValues);
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
                // The above line will always throw, but the compiler requires we throw explicitly.
                throw;
            }
        }

        protected override object VisitSingleton(SingletonCallSite singletonCallSite, ServiceProvider2 provider)
        {
            return VisitScoped(singletonCallSite, provider.Root);
        }

        protected override object VisitScoped(ScopedCallSite scopedCallSite, ServiceProvider2 provider)
        {
            object resolved;
            lock (provider.ResolvedServices)
            {
                if (!provider.ResolvedServices.TryGetValue(scopedCallSite.Key, out resolved))
                {
                    resolved = VisitCallSite(scopedCallSite.ServiceCallSite, provider);
                    provider.ResolvedServices.Add(scopedCallSite.Key, resolved);
                }
            }
            return resolved;
        }

        protected override object VisitConstant(ConstantCallSite constantCallSite, ServiceProvider2 provider)
        {
            return constantCallSite.DefaultValue;
        }

        protected override object VisitCreateInstance(CreateInstanceCallSite createInstanceCallSite, ServiceProvider2 provider)
        {
            try
            {
                return Activator.CreateInstance(createInstanceCallSite.Descriptor.ImplementationType);
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
                // The above line will always throw, but the compiler requires we throw explicitly.
                throw;
            }
        }

        protected override object VisitInstanceService(InstanceService instanceCallSite, ServiceProvider2 provider)
        {
            return instanceCallSite.Descriptor.ImplementationInstance;
        }

        protected override object VisitServiceProviderService(ServiceProviderService serviceProviderService, ServiceProvider2 provider)
        {
            return provider;
        }

        protected override object VisitEmptyIEnumerable(EmptyIEnumerableCallSite emptyIEnumerableCallSite, ServiceProvider2 provider)
        {
            return emptyIEnumerableCallSite.ServiceInstance;
        }

        protected override object VisitServiceScopeService(ServiceScopeService serviceScopeService, ServiceProvider2 provider)
        {
            return new ServiceScopeFactory(provider);
        }

        protected override object VisitClosedIEnumerable(ClosedIEnumerableCallSite closedIEnumerableCallSite, ServiceProvider2 provider)
        {
            var array = Array.CreateInstance(
                closedIEnumerableCallSite.ItemType,
                closedIEnumerableCallSite.ServiceCallSites.Length);

            for (var index = 0; index < closedIEnumerableCallSite.ServiceCallSites.Length; index++)
            {
                var value = VisitCallSite(closedIEnumerableCallSite.ServiceCallSites[index], provider);
                array.SetValue(value, index);
            }
            return array;
        }

        protected override object VisitFactoryService(FactoryService factoryService, ServiceProvider2 provider)
        {
            return factoryService.Descriptor.ImplementationFactory(provider);
        }
    }
}