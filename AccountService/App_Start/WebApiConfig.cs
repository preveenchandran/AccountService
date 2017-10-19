using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AccountContract;
using AccountRepository;
using System.Net.Http.Headers;
using AccountManager;

namespace AccountService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();
            container.RegisterType<IEnterpriseManager, EnterpriseManager>(new HierarchicalLifetimeManager());
            container.RegisterType<IEntAccountManager, EntAccountManager>(new HierarchicalLifetimeManager());

            container.RegisterType<IEnterpriseRepository, EnterpriseRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IEntAccountRepository, EntAccountRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    
    }
}
