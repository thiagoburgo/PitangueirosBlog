using System.Web.Http;
using System.Web.Http.Dispatcher;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Distribution.WebApi.IoC;

namespace Pitangueiros.Blog.Distribution.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Services.Replace(typeof(IHttpControllerActivator), new ApiControllerActivator(IocManager.Instance));

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
