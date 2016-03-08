public class MyAppContainer
{
    public static System.Collections.Generic.IEnumerable<Microsoft.Extensions.DependencyInjection.ServiceLookup.IService> GetServices()
    {
        yield return new Microsoft_AspNetCore_Routing_IInlineConstraintResolverService();
        yield return new Microsoft_AspNetCore_Routing_Internal_RoutingMarkerServiceService();
        yield return new Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_MvcOptionsService();
        yield return new Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Routing_RouteOptionsService();
        yield return new Microsoft_AspNetCore_Mvc_Infrastructure_IAssemblyProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Controllers_IControllerTypeProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ApplicationModels_IApplicationModelProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Abstractions_IActionDescriptorProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Infrastructure_IActionDescriptorCollectionProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Infrastructure_IActionSelectorService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_ActionConstraintCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_IActionSelectorDecisionTreeProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ActionConstraints_IActionConstraintProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Controllers_IControllerFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_Controllers_IControllerActivatorService();
        yield return new Microsoft_AspNetCore_Mvc_Controllers_IControllerPropertyActivatorService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_IActionInvokerFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_Abstractions_IActionInvokerProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Controllers_IControllerActionArgumentBinderService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_FilterCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Filters_IFilterProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ModelBinding_IModelMetadataProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ModelBinding_Validation_IObjectModelValidatorService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_ValidatorCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_ClientValidatorCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_MvcMarkerServiceService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_ITypeActivatorCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Routing_IUrlHelperFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_IHttpRequestStreamReaderFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_IHttpResponseStreamWriterFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_Internal_ObjectResultExecutorService();
        yield return new Microsoft_AspNetCore_Mvc_ApiExplorer_IApiDescriptionGroupCollectionProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ApiExplorer_IApiDescriptionProviderService();
        yield return new Microsoft_AspNetCore_Authorization_IAuthorizationServiceService();
        yield return new Microsoft_AspNetCore_Authorization_IAuthorizationPolicyProviderService();
        yield return new Microsoft_AspNetCore_Authorization_IAuthorizationHandlerService();
        yield return new Microsoft_AspNetCore_Mvc_Formatters_FormatFilterService();
        yield return new Microsoft_AspNetCore_Mvc_DataAnnotations_IValidationAttributeAdapterProviderService();
        yield return new Microsoft_AspNetCore_DataProtection_XmlEncryption_ICertificateResolverService();
        yield return new Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Antiforgery_AntiforgeryOptionsService();
        yield return new Microsoft_AspNetCore_Antiforgery_IAntiforgeryService();
        yield return new Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenGeneratorService();
        yield return new Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenSerializerService();
        yield return new Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenStoreService();
        yield return new Microsoft_AspNetCore_Antiforgery_Internal_IClaimUidExtractorService();
        yield return new Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryContextAccessorService();
        yield return new Microsoft_AspNetCore_Antiforgery_IAntiforgeryAdditionalDataProviderService();
        yield return new Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_MvcViewOptionsService();
        yield return new Microsoft_AspNetCore_Mvc_ViewEngines_ICompositeViewEngineService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_ViewResultExecutorService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_PartialViewResultExecutorService();
        yield return new Microsoft_AspNetCore_Mvc_Rendering_IHtmlHelperService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_IHtmlGeneratorService();
        yield return new Microsoft_AspNetCore_Mvc_Rendering_IJsonHelperService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentSelectorService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentActivatorService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentDescriptorCollectionProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentDescriptorProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentInvokerFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_IViewComponentHelperService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_ITempDataProviderService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_ValidateAntiforgeryTokenAuthorizationFilterService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_AutoValidateAntiforgeryTokenAuthorizationFilterService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_ITempDataDictionaryFactoryService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_SaveTempDataFilterService();
        yield return new Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_IViewBufferScopeService();
        yield return new Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_Razor_RazorViewEngineOptionsService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_Compilation_ICompilationServiceService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_Internal_IRazorViewEngineFileProviderAccessorService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_IRazorViewEngineService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_Internal_ICompilerCacheProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_IRazorPageFactoryProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_Compilation_IRazorCompilationServiceService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_IMvcRazorHostService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_IRazorPageActivatorService();
        yield return new Microsoft_AspNetCore_Mvc_Razor_ITagHelperActivatorService();
        yield return new Microsoft_Extensions_Caching_Memory_IMemoryCacheService();
        yield return new Microsoft_AspNetCore_Mvc_Formatters_Json_Internal_JsonResultExecutorService();
        yield return new Microsoft_AspNetCore_Cors_Infrastructure_ICorsServiceService();
        yield return new Microsoft_AspNetCore_Cors_Infrastructure_ICorsPolicyProviderService();
        yield return new Microsoft_AspNetCore_Mvc_Cors_Internal_CorsAuthorizationFilterService();
    }

    private class Microsoft_AspNetCore_Routing_IInlineConstraintResolverService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _routeOptions;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Routing.IInlineConstraintResolver);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Routing.DefaultInlineConstraintResolver)).GetConstructor(types);
            _routeOptions = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var routeOptions = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Routing.RouteOptions>)_routeOptions.Invoke(provider);
            return new Microsoft.AspNetCore.Routing.DefaultInlineConstraintResolver(routeOptions);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var routeOptions = _routeOptions.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, routeOptions);
        }
    }

    private class Microsoft_AspNetCore_Routing_Internal_RoutingMarkerServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Routing.Internal.RoutingMarkerService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Routing.Internal.RoutingMarkerService)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Routing.Internal.RoutingMarkerService();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Routing.Internal.RoutingMarkerService));
        }
    }

    private class Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_MvcOptionsService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _jsonOptions;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _charPool;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _objectPoolProvider;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[4];
            types[0] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            types[1] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>);
            types[2] = typeof(System.Buffers.ArrayPool<char>);
            types[3] = typeof(Microsoft.Extensions.ObjectPool.ObjectPoolProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.MvcJsonMvcOptionsSetup)).GetConstructor(types);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            _jsonOptions = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>), callSiteChain);
            _charPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<char>), callSiteChain);
            _objectPoolProvider = provider.GetServiceCallSite(typeof(Microsoft.Extensions.ObjectPool.ObjectPoolProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            var jsonOptions = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>)_jsonOptions.Invoke(provider);
            var charPool = (System.Buffers.ArrayPool<char>)_charPool.Invoke(provider);
            var objectPoolProvider = (Microsoft.Extensions.ObjectPool.ObjectPoolProvider)_objectPoolProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.MvcJsonMvcOptionsSetup(loggerFactory, jsonOptions, charPool, objectPoolProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var loggerFactory = _loggerFactory.Build(provider);
            var jsonOptions = _jsonOptions.Build(provider);
            var charPool = _charPool.Build(provider);
            var objectPoolProvider = _objectPoolProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, loggerFactory, jsonOptions, charPool, objectPoolProvider);
        }
    }

    private class Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Routing_RouteOptionsService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Routing.RouteOptions>);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.MvcCoreRouteOptionsSetup)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.MvcCoreRouteOptionsSetup();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.MvcCoreRouteOptionsSetup));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Infrastructure_IAssemblyProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _environment;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.DefaultAssemblyProvider)).GetConstructor(types);
            _environment = provider.GetServiceCallSite(typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var environment = (Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment)_environment.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Infrastructure.DefaultAssemblyProvider(environment);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var environment = _environment.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, environment);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Controllers_IControllerTypeProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _assemblyProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerTypeProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerTypeProvider)).GetConstructor(types);
            _assemblyProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var assemblyProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider)_assemblyProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerTypeProvider(assemblyProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var assemblyProvider = _assemblyProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, assemblyProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ApplicationModels_IApplicationModelProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Cors.Internal.CorsApplicationModelProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Cors.Internal.CorsApplicationModelProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Cors.Internal.CorsApplicationModelProvider));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Abstractions_IActionDescriptorProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _controllerTypeProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _applicationModelProviders;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Abstractions.IActionDescriptorProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerTypeProvider);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider>);
            types[2] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ControllerActionDescriptorProvider)).GetConstructor(types);
            _controllerTypeProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerTypeProvider), callSiteChain);
            _applicationModelProviders = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider>), callSiteChain);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var controllerTypeProvider = (Microsoft.AspNetCore.Mvc.Controllers.IControllerTypeProvider)_controllerTypeProvider.Invoke(provider);
            var applicationModelProviders = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApplicationModels.IApplicationModelProvider>)_applicationModelProviders.Invoke(provider);
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>)_optionsAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ControllerActionDescriptorProvider(controllerTypeProvider, applicationModelProviders, optionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var controllerTypeProvider = _controllerTypeProvider.Build(provider);
            var applicationModelProviders = _applicationModelProviders.Build(provider);
            var optionsAccessor = _optionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, controllerTypeProvider, applicationModelProviders, optionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Infrastructure_IActionDescriptorCollectionProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _serviceProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(System.IServiceProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionDescriptorCollectionProvider)).GetConstructor(types);
            _serviceProvider = provider.GetServiceCallSite(typeof(System.IServiceProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var serviceProvider = (System.IServiceProvider)_serviceProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ActionDescriptorCollectionProvider(serviceProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var serviceProvider = _serviceProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, serviceProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Infrastructure_IActionSelectorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _decisionTreeProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _actionConstraintCache;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionSelector);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Internal.IActionSelectorDecisionTreeProvider);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache);
            types[2] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionSelector)).GetConstructor(types);
            _decisionTreeProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.IActionSelectorDecisionTreeProvider), callSiteChain);
            _actionConstraintCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var decisionTreeProvider = (Microsoft.AspNetCore.Mvc.Internal.IActionSelectorDecisionTreeProvider)_decisionTreeProvider.Invoke(provider);
            var actionConstraintCache = (Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache)_actionConstraintCache.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ActionSelector(decisionTreeProvider, actionConstraintCache, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var decisionTreeProvider = _decisionTreeProvider.Build(provider);
            var actionConstraintCache = _actionConstraintCache.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, decisionTreeProvider, actionConstraintCache, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_ActionConstraintCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _collectionProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _actionConstraintProviders;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache)).GetConstructor(types);
            _collectionProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider), callSiteChain);
            _actionConstraintProviders = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var collectionProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)_collectionProvider.Invoke(provider);
            var actionConstraintProviders = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider>)_actionConstraintProviders.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ActionConstraintCache(collectionProvider, actionConstraintProviders);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var collectionProvider = _collectionProvider.Build(provider);
            var actionConstraintProviders = _actionConstraintProviders.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, collectionProvider, actionConstraintProviders);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_IActionSelectorDecisionTreeProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _actionDescriptorCollectionProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.IActionSelectorDecisionTreeProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionSelectorDecisionTreeProvider)).GetConstructor(types);
            _actionDescriptorCollectionProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var actionDescriptorCollectionProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)_actionDescriptorCollectionProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ActionSelectorDecisionTreeProvider(actionDescriptorCollectionProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var actionDescriptorCollectionProvider = _actionDescriptorCollectionProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, actionDescriptorCollectionProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ActionConstraints_IActionConstraintProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ActionConstraints.IActionConstraintProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.DefaultActionConstraintProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.DefaultActionConstraintProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.DefaultActionConstraintProvider));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Controllers_IControllerFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _controllerActivator;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _propertyActivators;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerFactory)).GetConstructor(types);
            _controllerActivator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator), callSiteChain);
            _propertyActivators = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var controllerActivator = (Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator)_controllerActivator.Invoke(provider);
            var propertyActivators = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator>)_propertyActivators.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerFactory(controllerActivator, propertyActivators);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var controllerActivator = _controllerActivator.Build(provider);
            var propertyActivators = _propertyActivators.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, controllerActivator, propertyActivators);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Controllers_IControllerActivatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _typeActivatorCache;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActivator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerActivator)).GetConstructor(types);
            _typeActivatorCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var typeActivatorCache = (Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache)_typeActivatorCache.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Controllers.DefaultControllerActivator(typeActivatorCache);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var typeActivatorCache = _typeActivatorCache.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, typeActivatorCache);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Controllers_IControllerPropertyActivatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _modelMetadataProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerPropertyActivator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionaryControllerPropertyActivator)).GetConstructor(types);
            _modelMetadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var modelMetadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_modelMetadataProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionaryControllerPropertyActivator(modelMetadataProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var modelMetadataProvider = _modelMetadataProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, modelMetadataProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_IActionInvokerFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _actionInvokerProviders;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.IActionInvokerFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ActionInvokerFactory)).GetConstructor(types);
            _actionInvokerProviders = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var actionInvokerProviders = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider>)_actionInvokerProviders.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ActionInvokerFactory(actionInvokerProviders);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var actionInvokerProviders = _actionInvokerProviders.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, actionInvokerProviders);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Abstractions_IActionInvokerProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _controllerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _filterCache;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _argumentBinder;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _diagnosticSource;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Abstractions.IActionInvokerProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[6];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.FilterCache);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActionArgumentBinder);
            types[3] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
            types[4] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            types[5] = typeof(System.Diagnostics.DiagnosticSource);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvokerProvider)).GetConstructor(types);
            _controllerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory), callSiteChain);
            _filterCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.FilterCache), callSiteChain);
            _argumentBinder = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActionArgumentBinder), callSiteChain);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            _diagnosticSource = provider.GetServiceCallSite(typeof(System.Diagnostics.DiagnosticSource), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var controllerFactory = (Microsoft.AspNetCore.Mvc.Controllers.IControllerFactory)_controllerFactory.Invoke(provider);
            var filterCache = (Microsoft.AspNetCore.Mvc.Internal.FilterCache)_filterCache.Invoke(provider);
            var argumentBinder = (Microsoft.AspNetCore.Mvc.Controllers.IControllerActionArgumentBinder)_argumentBinder.Invoke(provider);
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>)_optionsAccessor.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            var diagnosticSource = (System.Diagnostics.DiagnosticSource)_diagnosticSource.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ControllerActionInvokerProvider(controllerFactory, filterCache, argumentBinder, optionsAccessor, loggerFactory, diagnosticSource);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var controllerFactory = _controllerFactory.Build(provider);
            var filterCache = _filterCache.Build(provider);
            var argumentBinder = _argumentBinder.Build(provider);
            var optionsAccessor = _optionsAccessor.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            var diagnosticSource = _diagnosticSource.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, controllerFactory, filterCache, argumentBinder, optionsAccessor, loggerFactory, diagnosticSource);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Controllers_IControllerActionArgumentBinderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _modelMetadataProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _validator;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Controllers.IControllerActionArgumentBinder);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ControllerArgumentBinder)).GetConstructor(types);
            _modelMetadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            _validator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var modelMetadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_modelMetadataProvider.Invoke(provider);
            var validator = (Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator)_validator.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ControllerArgumentBinder(modelMetadataProvider, validator);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var modelMetadataProvider = _modelMetadataProvider.Build(provider);
            var validator = _validator.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, modelMetadataProvider, validator);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_FilterCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _collectionProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _filterProviders;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.FilterCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.FilterCache)).GetConstructor(types);
            _collectionProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider), callSiteChain);
            _filterProviders = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var collectionProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)_collectionProvider.Invoke(provider);
            var filterProviders = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.Filters.IFilterProvider>)_filterProviders.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.FilterCache(collectionProvider, filterProviders);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var collectionProvider = _collectionProvider.Build(provider);
            var filterProviders = _filterProviders.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, collectionProvider, filterProviders);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Filters_IFilterProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Filters.IFilterProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.DefaultFilterProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.DefaultFilterProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.DefaultFilterProvider));
        }
    }

    private class Microsoft_AspNetCore_Mvc_ModelBinding_IModelMetadataProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _detailsProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelMetadataProvider)).GetConstructor(types);
            _detailsProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var detailsProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.ICompositeMetadataDetailsProvider)_detailsProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.DefaultModelMetadataProvider(detailsProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var detailsProvider = _detailsProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, detailsProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ModelBinding_Validation_IObjectModelValidatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _modelMetadataProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _validatorCache;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ModelBinding.Validation.IObjectModelValidator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.ValidatorCache);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.DefaultObjectValidator)).GetConstructor(types);
            _modelMetadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            _validatorCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.ValidatorCache), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var modelMetadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_modelMetadataProvider.Invoke(provider);
            var validatorCache = (Microsoft.AspNetCore.Mvc.Internal.ValidatorCache)_validatorCache.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.DefaultObjectValidator(modelMetadataProvider, validatorCache);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var modelMetadataProvider = _modelMetadataProvider.Build(provider);
            var validatorCache = _validatorCache.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, modelMetadataProvider, validatorCache);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_ValidatorCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.ValidatorCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ValidatorCache)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.ValidatorCache();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.ValidatorCache));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_ClientValidatorCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_MvcMarkerServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.MvcMarkerService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.MvcMarkerService)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.MvcMarkerService();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.MvcMarkerService));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_ITypeActivatorCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.TypeActivatorCache)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Internal.TypeActivatorCache();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Internal.TypeActivatorCache));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Routing_IUrlHelperFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Routing.UrlHelperFactory)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Routing.UrlHelperFactory();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Routing.UrlHelperFactory));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_IHttpRequestStreamReaderFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _bytePool;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _charPool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpRequestStreamReaderFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(System.Buffers.ArrayPool<byte>);
            types[1] = typeof(System.Buffers.ArrayPool<char>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.MemoryPoolHttpRequestStreamReaderFactory)).GetConstructor(types);
            _bytePool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<byte>), callSiteChain);
            _charPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<char>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var bytePool = (System.Buffers.ArrayPool<byte>)_bytePool.Invoke(provider);
            var charPool = (System.Buffers.ArrayPool<char>)_charPool.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.MemoryPoolHttpRequestStreamReaderFactory(bytePool, charPool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var bytePool = _bytePool.Build(provider);
            var charPool = _charPool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, bytePool, charPool);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_IHttpResponseStreamWriterFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _bytePool;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _charPool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(System.Buffers.ArrayPool<byte>);
            types[1] = typeof(System.Buffers.ArrayPool<char>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.MemoryPoolHttpResponseStreamWriterFactory)).GetConstructor(types);
            _bytePool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<byte>), callSiteChain);
            _charPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<char>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var bytePool = (System.Buffers.ArrayPool<byte>)_bytePool.Invoke(provider);
            var charPool = (System.Buffers.ArrayPool<char>)_charPool.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.MemoryPoolHttpResponseStreamWriterFactory(bytePool, charPool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var bytePool = _bytePool.Build(provider);
            var charPool = _charPool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, bytePool, charPool);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Internal_ObjectResultExecutorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _writerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Internal.ObjectResultExecutor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory);
            types[2] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Internal.ObjectResultExecutor)).GetConstructor(types);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>), callSiteChain);
            _writerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>)_options.Invoke(provider);
            var writerFactory = (Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory)_writerFactory.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Internal.ObjectResultExecutor(options, writerFactory, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var options = _options.Build(provider);
            var writerFactory = _writerFactory.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, options, writerFactory, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ApiExplorer_IApiDescriptionGroupCollectionProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _actionDescriptorCollectionProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _apiDescriptionProviders;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionGroupCollectionProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroupCollectionProvider)).GetConstructor(types);
            _actionDescriptorCollectionProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider), callSiteChain);
            _apiDescriptionProviders = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var actionDescriptorCollectionProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IActionDescriptorCollectionProvider)_actionDescriptorCollectionProvider.Invoke(provider);
            var apiDescriptionProviders = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider>)_apiDescriptionProviders.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ApiExplorer.ApiDescriptionGroupCollectionProvider(actionDescriptorCollectionProvider, apiDescriptionProviders);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var actionDescriptorCollectionProvider = _actionDescriptorCollectionProvider.Build(provider);
            var apiDescriptionProviders = _apiDescriptionProviders.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, actionDescriptorCollectionProvider, apiDescriptionProviders);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ApiExplorer_IApiDescriptionProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _constraintResolver;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _modelMetadataProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ApiExplorer.IApiDescriptionProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
            types[1] = typeof(Microsoft.AspNetCore.Routing.IInlineConstraintResolver);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ApiExplorer.DefaultApiDescriptionProvider)).GetConstructor(types);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>), callSiteChain);
            _constraintResolver = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Routing.IInlineConstraintResolver), callSiteChain);
            _modelMetadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>)_optionsAccessor.Invoke(provider);
            var constraintResolver = (Microsoft.AspNetCore.Routing.IInlineConstraintResolver)_constraintResolver.Invoke(provider);
            var modelMetadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_modelMetadataProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ApiExplorer.DefaultApiDescriptionProvider(optionsAccessor, constraintResolver, modelMetadataProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var optionsAccessor = _optionsAccessor.Build(provider);
            var constraintResolver = _constraintResolver.Build(provider);
            var modelMetadataProvider = _modelMetadataProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, optionsAccessor, constraintResolver, modelMetadataProvider);
        }
    }

    private class Microsoft_AspNetCore_Authorization_IAuthorizationServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _policyProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _handlers;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _logger;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Authorization.IAuthorizationService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider);
            types[1] = typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizationHandler>);
            types[2] = typeof(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Authorization.DefaultAuthorizationService>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Authorization.DefaultAuthorizationService)).GetConstructor(types);
            _policyProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider), callSiteChain);
            _handlers = provider.GetServiceCallSite(typeof(System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizationHandler>), callSiteChain);
            _logger = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Authorization.DefaultAuthorizationService>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var policyProvider = (Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider)_policyProvider.Invoke(provider);
            var handlers = (System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Authorization.IAuthorizationHandler>)_handlers.Invoke(provider);
            var logger = (Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Authorization.DefaultAuthorizationService>)_logger.Invoke(provider);
            return new Microsoft.AspNetCore.Authorization.DefaultAuthorizationService(policyProvider, handlers, logger);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var policyProvider = _policyProvider.Build(provider);
            var handlers = _handlers.Build(provider);
            var logger = _logger.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, policyProvider, handlers, logger);
        }
    }

    private class Microsoft_AspNetCore_Authorization_IAuthorizationPolicyProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Authorization.AuthorizationOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Authorization.DefaultAuthorizationPolicyProvider)).GetConstructor(types);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Authorization.AuthorizationOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Authorization.AuthorizationOptions>)_options.Invoke(provider);
            return new Microsoft.AspNetCore.Authorization.DefaultAuthorizationPolicyProvider(options);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var options = _options.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, options);
        }
    }

    private class Microsoft_AspNetCore_Authorization_IAuthorizationHandlerService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Authorization.IAuthorizationHandler);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Authorization.Infrastructure.PassThroughAuthorizationHandler)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Authorization.Infrastructure.PassThroughAuthorizationHandler();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Authorization.Infrastructure.PassThroughAuthorizationHandler));
        }
    }

    private class Microsoft_AspNetCore_Mvc_Formatters_FormatFilterService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Formatters.FormatFilter);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Formatters.FormatFilter)).GetConstructor(types);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>)_options.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Formatters.FormatFilter(options);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var options = _options.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, options);
        }
    }

    private class Microsoft_AspNetCore_Mvc_DataAnnotations_IValidationAttributeAdapterProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.DataAnnotations.IValidationAttributeAdapterProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.DataAnnotations.Internal.ValidationAttributeAdapterProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.DataAnnotations.Internal.ValidationAttributeAdapterProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.DataAnnotations.Internal.ValidationAttributeAdapterProvider));
        }
    }

    private class Microsoft_AspNetCore_DataProtection_XmlEncryption_ICertificateResolverService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.DataProtection.XmlEncryption.ICertificateResolver);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateResolver)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateResolver();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateResolver));
        }
    }

    private class Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Antiforgery_AntiforgeryOptionsService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _dataProtectionOptionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.DataProtectionOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.AntiforgeryOptionsSetup)).GetConstructor(types);
            _dataProtectionOptionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.DataProtectionOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var dataProtectionOptionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.DataProtection.DataProtectionOptions>)_dataProtectionOptionsAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.AntiforgeryOptionsSetup(dataProtectionOptionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var dataProtectionOptionsAccessor = _dataProtectionOptionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, dataProtectionOptionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_IAntiforgeryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _antiforgeryOptionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _tokenGenerator;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _tokenSerializer;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _tokenStore;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[5];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>);
            types[1] = typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenGenerator);
            types[2] = typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenSerializer);
            types[3] = typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenStore);
            types[4] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgery)).GetConstructor(types);
            _antiforgeryOptionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>), callSiteChain);
            _tokenGenerator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenGenerator), callSiteChain);
            _tokenSerializer = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenSerializer), callSiteChain);
            _tokenStore = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenStore), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var antiforgeryOptionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>)_antiforgeryOptionsAccessor.Invoke(provider);
            var tokenGenerator = (Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenGenerator)_tokenGenerator.Invoke(provider);
            var tokenSerializer = (Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenSerializer)_tokenSerializer.Invoke(provider);
            var tokenStore = (Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenStore)_tokenStore.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgery(antiforgeryOptionsAccessor, tokenGenerator, tokenSerializer, tokenStore, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var antiforgeryOptionsAccessor = _antiforgeryOptionsAccessor.Build(provider);
            var tokenGenerator = _tokenGenerator.Build(provider);
            var tokenSerializer = _tokenSerializer.Build(provider);
            var tokenStore = _tokenStore.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, antiforgeryOptionsAccessor, tokenGenerator, tokenSerializer, tokenStore, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenGeneratorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _claimUidExtractor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _additionalDataProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenGenerator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Antiforgery.Internal.IClaimUidExtractor);
            types[1] = typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenGenerator)).GetConstructor(types);
            _claimUidExtractor = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.Internal.IClaimUidExtractor), callSiteChain);
            _additionalDataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var claimUidExtractor = (Microsoft.AspNetCore.Antiforgery.Internal.IClaimUidExtractor)_claimUidExtractor.Invoke(provider);
            var additionalDataProvider = (Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider)_additionalDataProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenGenerator(claimUidExtractor, additionalDataProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var claimUidExtractor = _claimUidExtractor.Build(provider);
            var additionalDataProvider = _additionalDataProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, claimUidExtractor, additionalDataProvider);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenSerializerService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _provider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _pool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenSerializer);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider);
            types[1] = typeof(Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenSerializer)).GetConstructor(types);
            _provider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.DataProtection.IDataProtectionProvider), callSiteChain);
            _pool = provider.GetServiceCallSite(typeof(Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var provider = (Microsoft.AspNetCore.DataProtection.IDataProtectionProvider)_provider.Invoke(provider);
            var pool = (Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>)_pool.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenSerializer(provider, pool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var provider = _provider.Build(provider);
            var pool = _pool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, provider, pool);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryTokenStoreService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryTokenStore);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenStore)).GetConstructor(types);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions>)_optionsAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryTokenStore(optionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var optionsAccessor = _optionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, optionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_Internal_IClaimUidExtractorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _pool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.Internal.IClaimUidExtractor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultClaimUidExtractor)).GetConstructor(types);
            _pool = provider.GetServiceCallSite(typeof(Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var pool = (Microsoft.Extensions.ObjectPool.ObjectPool<Microsoft.AspNetCore.Antiforgery.Internal.AntiforgerySerializationContext>)_pool.Invoke(provider);
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultClaimUidExtractor(pool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var pool = _pool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, pool);
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_Internal_IAntiforgeryContextAccessorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.Internal.IAntiforgeryContextAccessor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryContextAccessor)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryContextAccessor();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryContextAccessor));
        }
    }

    private class Microsoft_AspNetCore_Antiforgery_IAntiforgeryAdditionalDataProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryAdditionalDataProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryAdditionalDataProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Antiforgery.Internal.DefaultAntiforgeryAdditionalDataProvider));
        }
    }

    private class Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_MvcViewOptionsService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _serviceProvider;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(System.IServiceProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.MvcRazorMvcViewOptionsSetup)).GetConstructor(types);
            _serviceProvider = provider.GetServiceCallSite(typeof(System.IServiceProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var serviceProvider = (System.IServiceProvider)_serviceProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.MvcRazorMvcViewOptionsSetup(serviceProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var serviceProvider = _serviceProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, serviceProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewEngines_ICompositeViewEngineService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewEngines.CompositeViewEngine)).GetConstructor(types);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>)_optionsAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewEngines.CompositeViewEngine(optionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var optionsAccessor = _optionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, optionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_ViewResultExecutorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewOptions;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _writerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewEngine;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _tempDataFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _diagnosticSource;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewResultExecutor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[6];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory);
            types[4] = typeof(System.Diagnostics.DiagnosticSource);
            types[5] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewResultExecutor)).GetConstructor(types);
            _viewOptions = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), callSiteChain);
            _writerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory), callSiteChain);
            _viewEngine = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), callSiteChain);
            _tempDataFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), callSiteChain);
            _diagnosticSource = provider.GetServiceCallSite(typeof(System.Diagnostics.DiagnosticSource), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var viewOptions = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>)_viewOptions.Invoke(provider);
            var writerFactory = (Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory)_writerFactory.Invoke(provider);
            var viewEngine = (Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine)_viewEngine.Invoke(provider);
            var tempDataFactory = (Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory)_tempDataFactory.Invoke(provider);
            var diagnosticSource = (System.Diagnostics.DiagnosticSource)_diagnosticSource.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewResultExecutor(viewOptions, writerFactory, viewEngine, tempDataFactory, diagnosticSource, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var viewOptions = _viewOptions.Build(provider);
            var writerFactory = _writerFactory.Build(provider);
            var viewEngine = _viewEngine.Build(provider);
            var tempDataFactory = _tempDataFactory.Build(provider);
            var diagnosticSource = _diagnosticSource.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, viewOptions, writerFactory, viewEngine, tempDataFactory, diagnosticSource, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_PartialViewResultExecutorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewOptions;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _writerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewEngine;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _tempDataFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _diagnosticSource;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.PartialViewResultExecutor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[6];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory);
            types[4] = typeof(System.Diagnostics.DiagnosticSource);
            types[5] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.PartialViewResultExecutor)).GetConstructor(types);
            _viewOptions = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), callSiteChain);
            _writerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory), callSiteChain);
            _viewEngine = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), callSiteChain);
            _tempDataFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), callSiteChain);
            _diagnosticSource = provider.GetServiceCallSite(typeof(System.Diagnostics.DiagnosticSource), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var viewOptions = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>)_viewOptions.Invoke(provider);
            var writerFactory = (Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory)_writerFactory.Invoke(provider);
            var viewEngine = (Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine)_viewEngine.Invoke(provider);
            var tempDataFactory = (Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory)_tempDataFactory.Invoke(provider);
            var diagnosticSource = (System.Diagnostics.DiagnosticSource)_diagnosticSource.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.PartialViewResultExecutor(viewOptions, writerFactory, viewEngine, tempDataFactory, diagnosticSource, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var viewOptions = _viewOptions.Build(provider);
            var writerFactory = _writerFactory.Build(provider);
            var viewEngine = _viewEngine.Build(provider);
            var tempDataFactory = _tempDataFactory.Build(provider);
            var diagnosticSource = _diagnosticSource.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, viewOptions, writerFactory, viewEngine, tempDataFactory, diagnosticSource, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Rendering_IHtmlHelperService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _htmlGenerator;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewEngine;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _metadataProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _bufferScope;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _htmlEncoder;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _urlEncoder;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[6];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope);
            types[4] = typeof(System.Text.Encodings.Web.HtmlEncoder);
            types[5] = typeof(System.Text.Encodings.Web.UrlEncoder);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper)).GetConstructor(types);
            _htmlGenerator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator), callSiteChain);
            _viewEngine = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine), callSiteChain);
            _metadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            _bufferScope = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope), callSiteChain);
            _htmlEncoder = provider.GetServiceCallSite(typeof(System.Text.Encodings.Web.HtmlEncoder), callSiteChain);
            _urlEncoder = provider.GetServiceCallSite(typeof(System.Text.Encodings.Web.UrlEncoder), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var htmlGenerator = (Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator)_htmlGenerator.Invoke(provider);
            var viewEngine = (Microsoft.AspNetCore.Mvc.ViewEngines.ICompositeViewEngine)_viewEngine.Invoke(provider);
            var metadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_metadataProvider.Invoke(provider);
            var bufferScope = (Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope)_bufferScope.Invoke(provider);
            var htmlEncoder = (System.Text.Encodings.Web.HtmlEncoder)_htmlEncoder.Invoke(provider);
            var urlEncoder = (System.Text.Encodings.Web.UrlEncoder)_urlEncoder.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper(htmlGenerator, viewEngine, metadataProvider, bufferScope, htmlEncoder, urlEncoder);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var htmlGenerator = _htmlGenerator.Build(provider);
            var viewEngine = _viewEngine.Build(provider);
            var metadataProvider = _metadataProvider.Build(provider);
            var bufferScope = _bufferScope.Build(provider);
            var htmlEncoder = _htmlEncoder.Build(provider);
            var urlEncoder = _urlEncoder.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, htmlGenerator, viewEngine, metadataProvider, bufferScope, htmlEncoder, urlEncoder);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_IHtmlGeneratorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _antiforgery;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _metadataProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _urlHelperFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _htmlEncoder;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _clientValidatorCache;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.IHtmlGenerator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[6];
            types[0] = typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery);
            types[1] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory);
            types[4] = typeof(System.Text.Encodings.Web.HtmlEncoder);
            types[5] = typeof(Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.DefaultHtmlGenerator)).GetConstructor(types);
            _antiforgery = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery), callSiteChain);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>), callSiteChain);
            _metadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            _urlHelperFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory), callSiteChain);
            _htmlEncoder = provider.GetServiceCallSite(typeof(System.Text.Encodings.Web.HtmlEncoder), callSiteChain);
            _clientValidatorCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var antiforgery = (Microsoft.AspNetCore.Antiforgery.IAntiforgery)_antiforgery.Invoke(provider);
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcViewOptions>)_optionsAccessor.Invoke(provider);
            var metadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_metadataProvider.Invoke(provider);
            var urlHelperFactory = (Microsoft.AspNetCore.Mvc.Routing.IUrlHelperFactory)_urlHelperFactory.Invoke(provider);
            var htmlEncoder = (System.Text.Encodings.Web.HtmlEncoder)_htmlEncoder.Invoke(provider);
            var clientValidatorCache = (Microsoft.AspNetCore.Mvc.Internal.ClientValidatorCache)_clientValidatorCache.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.DefaultHtmlGenerator(antiforgery, optionsAccessor, metadataProvider, urlHelperFactory, htmlEncoder, clientValidatorCache);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var antiforgery = _antiforgery.Build(provider);
            var optionsAccessor = _optionsAccessor.Build(provider);
            var metadataProvider = _metadataProvider.Build(provider);
            var urlHelperFactory = _urlHelperFactory.Build(provider);
            var htmlEncoder = _htmlEncoder.Build(provider);
            var clientValidatorCache = _clientValidatorCache.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, antiforgery, optionsAccessor, metadataProvider, urlHelperFactory, htmlEncoder, clientValidatorCache);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Rendering_IJsonHelperService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _jsonOutputFormatter;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Formatters.JsonOutputFormatter);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.JsonHelper)).GetConstructor(types);
            _jsonOutputFormatter = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Formatters.JsonOutputFormatter), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var jsonOutputFormatter = (Microsoft.AspNetCore.Mvc.Formatters.JsonOutputFormatter)_jsonOutputFormatter.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.JsonHelper(jsonOutputFormatter);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var jsonOutputFormatter = _jsonOutputFormatter.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, jsonOutputFormatter);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentSelectorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _descriptorProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentSelector)).GetConstructor(types);
            _descriptorProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var descriptorProvider = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider)_descriptorProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentSelector(descriptorProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var descriptorProvider = _descriptorProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, descriptorProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _activator;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentFactory)).GetConstructor(types);
            _activator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var activator = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator)_activator.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentFactory(activator);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var activator = _activator.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, activator);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentActivatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _typeActivatorCache;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentActivator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentActivator)).GetConstructor(types);
            _typeActivatorCache = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var typeActivatorCache = (Microsoft.AspNetCore.Mvc.Internal.ITypeActivatorCache)_typeActivatorCache.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentActivator(typeActivatorCache);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var typeActivatorCache = _typeActivatorCache.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, typeActivatorCache);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentDescriptorCollectionProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _descriptorProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentDescriptorCollectionProvider)).GetConstructor(types);
            _descriptorProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var descriptorProvider = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider)_descriptorProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentDescriptorCollectionProvider(descriptorProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var descriptorProvider = _descriptorProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, descriptorProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentDescriptorProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _assemblyProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentDescriptorProvider)).GetConstructor(types);
            _assemblyProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var assemblyProvider = (Microsoft.AspNetCore.Mvc.Infrastructure.IAssemblyProvider)_assemblyProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentDescriptorProvider(assemblyProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var assemblyProvider = _assemblyProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, assemblyProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewComponents_IViewComponentInvokerFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewComponentFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _diagnosticSource;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[3];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory);
            types[1] = typeof(System.Diagnostics.DiagnosticSource);
            types[2] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentInvokerFactory)).GetConstructor(types);
            _viewComponentFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory), callSiteChain);
            _diagnosticSource = provider.GetServiceCallSite(typeof(System.Diagnostics.DiagnosticSource), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var viewComponentFactory = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentFactory)_viewComponentFactory.Invoke(provider);
            var diagnosticSource = (System.Diagnostics.DiagnosticSource)_diagnosticSource.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentInvokerFactory(viewComponentFactory, diagnosticSource, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var viewComponentFactory = _viewComponentFactory.Build(provider);
            var diagnosticSource = _diagnosticSource.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, viewComponentFactory, diagnosticSource, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_IViewComponentHelperService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _descriptorProvider;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _htmlEncoder;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _selector;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _invokerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewBufferScope;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.IViewComponentHelper);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[5];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider);
            types[1] = typeof(System.Text.Encodings.Web.HtmlEncoder);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory);
            types[4] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentHelper)).GetConstructor(types);
            _descriptorProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider), callSiteChain);
            _htmlEncoder = provider.GetServiceCallSite(typeof(System.Text.Encodings.Web.HtmlEncoder), callSiteChain);
            _selector = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector), callSiteChain);
            _invokerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory), callSiteChain);
            _viewBufferScope = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var descriptorProvider = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentDescriptorCollectionProvider)_descriptorProvider.Invoke(provider);
            var htmlEncoder = (System.Text.Encodings.Web.HtmlEncoder)_htmlEncoder.Invoke(provider);
            var selector = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentSelector)_selector.Invoke(provider);
            var invokerFactory = (Microsoft.AspNetCore.Mvc.ViewComponents.IViewComponentInvokerFactory)_invokerFactory.Invoke(provider);
            var viewBufferScope = (Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope)_viewBufferScope.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewComponents.DefaultViewComponentHelper(descriptorProvider, htmlEncoder, selector, invokerFactory, viewBufferScope);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var descriptorProvider = _descriptorProvider.Build(provider);
            var htmlEncoder = _htmlEncoder.Build(provider);
            var selector = _selector.Build(provider);
            var invokerFactory = _invokerFactory.Build(provider);
            var viewBufferScope = _viewBufferScope.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, descriptorProvider, htmlEncoder, selector, invokerFactory, viewBufferScope);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_ITempDataProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.SessionStateTempDataProvider)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.SessionStateTempDataProvider();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.SessionStateTempDataProvider));
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_ValidateAntiforgeryTokenAuthorizationFilterService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _antiforgery;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ValidateAntiforgeryTokenAuthorizationFilter);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery);
            types[1] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ValidateAntiforgeryTokenAuthorizationFilter)).GetConstructor(types);
            _antiforgery = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var antiforgery = (Microsoft.AspNetCore.Antiforgery.IAntiforgery)_antiforgery.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ValidateAntiforgeryTokenAuthorizationFilter(antiforgery, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var antiforgery = _antiforgery.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, antiforgery, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_AutoValidateAntiforgeryTokenAuthorizationFilterService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _antiforgery;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.AutoValidateAntiforgeryTokenAuthorizationFilter);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery);
            types[1] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.AutoValidateAntiforgeryTokenAuthorizationFilter)).GetConstructor(types);
            _antiforgery = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Antiforgery.IAntiforgery), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var antiforgery = (Microsoft.AspNetCore.Antiforgery.IAntiforgery)_antiforgery.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.AutoValidateAntiforgeryTokenAuthorizationFilter(antiforgery, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var antiforgery = _antiforgery.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, antiforgery, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_ITempDataDictionaryFactoryService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _provider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.TempDataDictionaryFactory)).GetConstructor(types);
            _provider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var provider = (Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataProvider)_provider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.TempDataDictionaryFactory(provider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var provider = _provider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, provider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_SaveTempDataFilterService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _factory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.SaveTempDataFilter);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.SaveTempDataFilter)).GetConstructor(types);
            _factory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var factory = (Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionaryFactory)_factory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.SaveTempDataFilter(factory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var factory = _factory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, factory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_ViewFeatures_Internal_IViewBufferScopeService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _viewBufferPool;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _charPool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.IViewBufferScope);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(System.Buffers.ArrayPool<Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewBufferValue>);
            types[1] = typeof(System.Buffers.ArrayPool<char>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.MemoryPoolViewBufferScope)).GetConstructor(types);
            _viewBufferPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewBufferValue>), callSiteChain);
            _charPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<char>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var viewBufferPool = (System.Buffers.ArrayPool<Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewBufferValue>)_viewBufferPool.Invoke(provider);
            var charPool = (System.Buffers.ArrayPool<char>)_charPool.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.MemoryPoolViewBufferScope(viewBufferPool, charPool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var viewBufferPool = _viewBufferPool.Build(provider);
            var charPool = _charPool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, viewBufferPool, charPool);
        }
    }

    private class Microsoft_Extensions_Options_IConfigureOptions_1_Microsoft_AspNetCore_Mvc_Razor_RazorViewEngineOptionsService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _applicationEnvironment;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _hostingEnvironment;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Options.IConfigureOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment);
            types[1] = typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.RazorViewEngineOptionsSetup)).GetConstructor(types);
            _applicationEnvironment = provider.GetServiceCallSite(typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment), callSiteChain);
            _hostingEnvironment = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Hosting.IHostingEnvironment), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var applicationEnvironment = (Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment)_applicationEnvironment.Invoke(provider);
            var hostingEnvironment = (Microsoft.AspNetCore.Hosting.IHostingEnvironment)_hostingEnvironment.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.RazorViewEngineOptionsSetup(applicationEnvironment, hostingEnvironment);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var applicationEnvironment = _applicationEnvironment.Build(provider);
            var hostingEnvironment = _hostingEnvironment.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, applicationEnvironment, hostingEnvironment);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_Compilation_ICompilationServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _environment;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _host;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _fileProviderAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.ICompilationService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[5];
            types[0] = typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost);
            types[2] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>);
            types[3] = typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor);
            types[4] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRoslynCompilationService)).GetConstructor(types);
            _environment = provider.GetServiceCallSite(typeof(Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment), callSiteChain);
            _host = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost), callSiteChain);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>), callSiteChain);
            _fileProviderAccessor = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var environment = (Microsoft.Extensions.PlatformAbstractions.IApplicationEnvironment)_environment.Invoke(provider);
            var host = (Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost)_host.Invoke(provider);
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>)_optionsAccessor.Invoke(provider);
            var fileProviderAccessor = (Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor)_fileProviderAccessor.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRoslynCompilationService(environment, host, optionsAccessor, fileProviderAccessor, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var environment = _environment.Build(provider);
            var host = _host.Build(provider);
            var optionsAccessor = _optionsAccessor.Build(provider);
            var fileProviderAccessor = _fileProviderAccessor.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, environment, host, optionsAccessor, fileProviderAccessor, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_Internal_IRazorViewEngineFileProviderAccessorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorViewEngineFileProviderAccessor)).GetConstructor(types);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>)_optionsAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorViewEngineFileProviderAccessor(optionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var optionsAccessor = _optionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, optionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_IRazorViewEngineService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _pageFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _pageActivator;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _htmlEncoder;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorViewEngine);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[5];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator);
            types[2] = typeof(System.Text.Encodings.Web.HtmlEncoder);
            types[3] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>);
            types[4] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine)).GetConstructor(types);
            _pageFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider), callSiteChain);
            _pageActivator = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator), callSiteChain);
            _htmlEncoder = provider.GetServiceCallSite(typeof(System.Text.Encodings.Web.HtmlEncoder), callSiteChain);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var pageFactory = (Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider)_pageFactory.Invoke(provider);
            var pageActivator = (Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator)_pageActivator.Invoke(provider);
            var htmlEncoder = (System.Text.Encodings.Web.HtmlEncoder)_htmlEncoder.Invoke(provider);
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>)_optionsAccessor.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine(pageFactory, pageActivator, htmlEncoder, optionsAccessor, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var pageFactory = _pageFactory.Build(provider);
            var pageActivator = _pageActivator.Build(provider);
            var htmlEncoder = _htmlEncoder.Build(provider);
            var optionsAccessor = _optionsAccessor.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, pageFactory, pageActivator, htmlEncoder, optionsAccessor, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_Internal_ICompilerCacheProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _fileProviderAccessor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.ICompilerCacheProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultCompilerCacheProvider)).GetConstructor(types);
            _fileProviderAccessor = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var fileProviderAccessor = (Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor)_fileProviderAccessor.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultCompilerCacheProvider(fileProviderAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var fileProviderAccessor = _fileProviderAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, fileProviderAccessor);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_IRazorPageFactoryProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _razorCompilationService;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _compilerCacheProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageFactoryProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.IRazorCompilationService);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.ICompilerCacheProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorPageFactoryProvider)).GetConstructor(types);
            _razorCompilationService = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.IRazorCompilationService), callSiteChain);
            _compilerCacheProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.ICompilerCacheProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var razorCompilationService = (Microsoft.AspNetCore.Mvc.Razor.Compilation.IRazorCompilationService)_razorCompilationService.Invoke(provider);
            var compilerCacheProvider = (Microsoft.AspNetCore.Mvc.Razor.Internal.ICompilerCacheProvider)_compilerCacheProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorPageFactoryProvider(razorCompilationService, compilerCacheProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var razorCompilationService = _razorCompilationService.Build(provider);
            var compilerCacheProvider = _compilerCacheProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, razorCompilationService, compilerCacheProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_Compilation_IRazorCompilationServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _compilationService;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _razorHost;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _fileProviderAccessor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _loggerFactory;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.IRazorCompilationService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[4];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.ICompilationService);
            types[1] = typeof(Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost);
            types[2] = typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor);
            types[3] = typeof(Microsoft.Extensions.Logging.ILoggerFactory);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.RazorCompilationService)).GetConstructor(types);
            _compilationService = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Compilation.ICompilationService), callSiteChain);
            _razorHost = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost), callSiteChain);
            _fileProviderAccessor = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor), callSiteChain);
            _loggerFactory = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILoggerFactory), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var compilationService = (Microsoft.AspNetCore.Mvc.Razor.Compilation.ICompilationService)_compilationService.Invoke(provider);
            var razorHost = (Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost)_razorHost.Invoke(provider);
            var fileProviderAccessor = (Microsoft.AspNetCore.Mvc.Razor.Internal.IRazorViewEngineFileProviderAccessor)_fileProviderAccessor.Invoke(provider);
            var loggerFactory = (Microsoft.Extensions.Logging.ILoggerFactory)_loggerFactory.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.RazorCompilationService(compilationService, razorHost, fileProviderAccessor, loggerFactory);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var compilationService = _compilationService.Build(provider);
            var razorHost = _razorHost.Build(provider);
            var fileProviderAccessor = _fileProviderAccessor.Build(provider);
            var loggerFactory = _loggerFactory.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, compilationService, razorHost, fileProviderAccessor, loggerFactory);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_IMvcRazorHostService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _root;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.IMvcRazorHost);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(string);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.MvcRazorHost)).GetConstructor(types);
            _root = provider.GetServiceCallSite(typeof(string), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var root = (string)_root.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.MvcRazorHost(root);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var root = _root.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, root);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_IRazorPageActivatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _metadataProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.IRazorPageActivator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.RazorPageActivator)).GetConstructor(types);
            _metadataProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var metadataProvider = (Microsoft.AspNetCore.Mvc.ModelBinding.IModelMetadataProvider)_metadataProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Razor.RazorPageActivator(metadataProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var metadataProvider = _metadataProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, metadataProvider);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Razor_ITagHelperActivatorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Razor.ITagHelperActivator);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = System.Type.EmptyTypes;
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultTagHelperActivator)).GetConstructor(types);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            return new Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultTagHelperActivator();
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            return System.Linq.Expressions.Expression.New(typeof(Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultTagHelperActivator));
        }
    }

    private class Microsoft_Extensions_Caching_Memory_IMemoryCacheService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _optionsAccessor;
        public System.Type ServiceType => typeof(Microsoft.Extensions.Caching.Memory.IMemoryCache);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Caching.Memory.MemoryCacheOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.Extensions.Caching.Memory.MemoryCache)).GetConstructor(types);
            _optionsAccessor = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Caching.Memory.MemoryCacheOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var optionsAccessor = (Microsoft.Extensions.Options.IOptions<Microsoft.Extensions.Caching.Memory.MemoryCacheOptions>)_optionsAccessor.Invoke(provider);
            return new Microsoft.Extensions.Caching.Memory.MemoryCache(optionsAccessor);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var optionsAccessor = _optionsAccessor.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, optionsAccessor);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Formatters_Json_Internal_JsonResultExecutorService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _writerFactory;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _logger;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _charPool;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[4];
            types[0] = typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory);
            types[1] = typeof(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor>);
            types[2] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>);
            types[3] = typeof(System.Buffers.ArrayPool<char>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor)).GetConstructor(types);
            _writerFactory = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory), callSiteChain);
            _logger = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor>), callSiteChain);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>), callSiteChain);
            _charPool = provider.GetServiceCallSite(typeof(System.Buffers.ArrayPool<char>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var writerFactory = (Microsoft.AspNetCore.Mvc.Internal.IHttpResponseStreamWriterFactory)_writerFactory.Invoke(provider);
            var logger = (Microsoft.Extensions.Logging.ILogger<Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor>)_logger.Invoke(provider);
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Mvc.MvcJsonOptions>)_options.Invoke(provider);
            var charPool = (System.Buffers.ArrayPool<char>)_charPool.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Formatters.Json.Internal.JsonResultExecutor(writerFactory, logger, options, charPool);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var writerFactory = _writerFactory.Build(provider);
            var logger = _logger.Build(provider);
            var options = _options.Build(provider);
            var charPool = _charPool.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, writerFactory, logger, options, charPool);
        }
    }

    private class Microsoft_AspNetCore_Cors_Infrastructure_ICorsServiceService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsService);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Cors.Infrastructure.CorsService)).GetConstructor(types);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>)_options.Invoke(provider);
            return new Microsoft.AspNetCore.Cors.Infrastructure.CorsService(options);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var options = _options.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, options);
        }
    }

    private class Microsoft_AspNetCore_Cors_Infrastructure_ICorsPolicyProviderService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _options;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[1];
            types[0] = typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Cors.Infrastructure.DefaultCorsPolicyProvider)).GetConstructor(types);
            _options = provider.GetServiceCallSite(typeof(Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var options = (Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions>)_options.Invoke(provider);
            return new Microsoft.AspNetCore.Cors.Infrastructure.DefaultCorsPolicyProvider(options);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var options = _options.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, options);
        }
    }

    private class Microsoft_AspNetCore_Mvc_Cors_Internal_CorsAuthorizationFilterService : Microsoft.Extensions.DependencyInjection.ServiceLookup.IService, Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite
    {
        private System.Reflection.ConstructorInfo _ctor;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _corsService;
        private Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite _policyProvider;
        public System.Type ServiceType => typeof(Microsoft.AspNetCore.Mvc.Cors.Internal.CorsAuthorizationFilter);
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IService Next { get; set; }
        public Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime => Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient;
        public Microsoft.Extensions.DependencyInjection.ServiceLookup.IServiceCallSite CreateCallSite(Microsoft.Extensions.DependencyInjection.ServiceProvider provider, System.Collections.Generic.ISet<System.Type> callSiteChain)
        {
            var types = new System.Type[2];
            types[0] = typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsService);
            types[1] = typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider);
            _ctor = System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Microsoft.AspNetCore.Mvc.Cors.Internal.CorsAuthorizationFilter)).GetConstructor(types);
            _corsService = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsService), callSiteChain);
            _policyProvider = provider.GetServiceCallSite(typeof(Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider), callSiteChain);
            return this;
        }
        public object Invoke(Microsoft.Extensions.DependencyInjection.ServiceProvider provider)
        {
            var corsService = (Microsoft.AspNetCore.Cors.Infrastructure.ICorsService)_corsService.Invoke(provider);
            var policyProvider = (Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider)_policyProvider.Invoke(provider);
            return new Microsoft.AspNetCore.Mvc.Cors.Internal.CorsAuthorizationFilter(corsService, policyProvider);
        }

        public System.Linq.Expressions.Expression Build(System.Linq.Expressions.Expression provider)
        {
            var corsService = _corsService.Build(provider);
            var policyProvider = _policyProvider.Build(provider);
            return System.Linq.Expressions.Expression.New(_ctor, corsService, policyProvider);
        }
    }

}
