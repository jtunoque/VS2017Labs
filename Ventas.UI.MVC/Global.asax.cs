using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Ventas.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("Application Error");

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Application_Error()
        {
            var objError = Server.GetLastError().GetBaseException();

            logger.Error(objError);
        }

    }
}
