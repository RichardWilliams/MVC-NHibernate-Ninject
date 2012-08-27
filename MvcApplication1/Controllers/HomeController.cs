using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }

        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            ViewBag.Message = _log.HelloWorld();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
