using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCViewsUpg4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Hexa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sprite", action = "Hexa", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Octa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Sprite", action = "Octa", id = UrlParameter.Optional }
            );
        }
    }
}
