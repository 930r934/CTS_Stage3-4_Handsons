using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4netHandson.Controllers
{
    public class HomeController : Controller

    {
        private readonly ILog log = LogManager.GetLogger(typeof(HomeController));

        public HomeController()
        {
            log.Info("Constructor of HomeController");
        }
        public ActionResult Index()
        {

            try
            {
                log.Info("Index Page!");
                log.Debug("Debug Message test");
                log.Warn("Warning Message test");
                log.Error("Error Test Log test");

            }
            catch(Exception e)
            {
                log.Warn("Error Message" + e.Message);
            }




            return View();
        }
         
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}