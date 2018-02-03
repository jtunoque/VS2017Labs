using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ventas.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("HomeController");

        public ActionResult Index()
        {
            //try
            //{
              // throw new Exception("Generando un error");

                logger.Info("Antes de llamar a la vista Index");
            //}
            //catch(Exception ex)
            //{
              //  logger.Error(ex);
            //}
    
            return View();
        }

        public ActionResult About()
        {
            logger.Info("Antes de llamar a la vista About");


            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            logger.Info("Antes de llamar a la vista Contact");

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Html5Test()
        {
            return View();
        }

    }
}