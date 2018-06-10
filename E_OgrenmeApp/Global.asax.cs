﻿using E_OgrenmeApp.App_Start;
using E_OgrenmeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace E_OgrenmeApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.Configure();

        }
        protected void Application_BeginRequest()
        {
            Database.OpenSession();
        }
        protected void Application_EndRequest()
        {
            Database.CloseSession();
        }
    }
}