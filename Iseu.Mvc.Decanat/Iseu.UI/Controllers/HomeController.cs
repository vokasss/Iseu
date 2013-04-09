using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iseu.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View("~/views/home/index.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View("~/views/home/about.cshtml");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("~/views/home/contact.cshtml");
        }
    }
}
