using GamingApp.DAC.DataAccess.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using GamingApp.Domain.Interfaces.Service;
using GamingApp.Services;
using GamingAppBackEnd.App_Start;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;

namespace GamingAppBackEnd
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IStatisticsService, StatisticsService>();
            container.RegisterType<IGamingAppDAC, GamingAppDAC>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Configuración y servicios de API web
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
