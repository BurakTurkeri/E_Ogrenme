using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using E_OgrenmeApp.Controllers;
namespace E_OgrenmeApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(HomeController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Home", action = "anasayfa" }, new[] { "E_OgrenmeApp.Controllers" });
            routes.MapRoute("Matematik", "matematik", new { controller = "List", action = "Math" }, new[] { "E_OgrenmeApp.Controllers" });
            routes.MapRoute("Fizik", "fizik", new { controller = "List", action = "Pysics" }, new[] { "E_OgrenmeApp.Controllers" });
            routes.MapRoute("Kimya", "kimya", new { controller = "List", action = "Chemical" }, new[] { "E_OgrenmeApp.Controllers" });
            routes.MapRoute("Biyoloji", "biyoloji", new { controller = "List", action = "Biology" }, new[] { "E_OgrenmeApp.Controllers" });
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute("VideoAra", "VideoAra", new { controller = "Home", action = "VideoAra" }, namespaces);
            routes.MapRoute("Detay", "Detay", new { controller = "Home", action = "Detay" }, namespaces);
        }
    }
}
