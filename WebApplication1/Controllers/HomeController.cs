using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { return View(); }

        public ActionResult About()
        {
            ViewData["view"] = "A";
            return View(); }

        public ActionResult Contact()
        {
            ViewData["view"] = "C";
            return View();
        }

        public ActionResult Projects()
        {
            ViewData["view"] = "P";
            return View();
        }

        public ActionResult Game()
        {
            ViewData["view"] = "G";
            return View();
        }
    }
}