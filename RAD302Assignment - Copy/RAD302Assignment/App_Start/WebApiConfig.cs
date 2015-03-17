using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RAD302Assignment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Setting up JSON so when viewing an object directly from the API, it looks a lot tidier.
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling =
                Newtonsoft.Json.PreserveReferencesHandling.Objects;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
