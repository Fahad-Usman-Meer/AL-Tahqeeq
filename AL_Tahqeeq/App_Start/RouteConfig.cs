using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AL_Tahqeeq
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Masla",
                url: "Masla/{viewName}/",
                defaults: new { controller = "Masla", action = "GetView" }
            );

            routes.MapRoute(
                name: "MaslaPDF",
                url: "MaslaPDF/{fileName}",
                defaults: new { controller = "Masla", action = "GetPDF" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
