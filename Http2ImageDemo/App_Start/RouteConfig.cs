using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Http2ImageDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //routes.MapRoute(
            //    name: "DefaultDemo",
            //    url: "Demo/{image}",
            //    defaults: new { controller = "Home", action = "Index", image = UrlParameter.Optional }
            //);
            
            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{image}",
               defaults: new { controller = "Home", action = "Index", image = UrlParameter.Optional }
           );
        }
    }
}
