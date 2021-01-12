using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Control_cash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Conte-me mais sobre o Control Cash...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Redes Sociais";

            return View();
        }
    }
}