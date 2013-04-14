using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Iseu.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
           
            return View("~/views/home/index.cshtml");
        }

        public ActionResult About()
        {
            return View("~/views/home/about.cshtml");
        }

        public ActionResult Contact()
        {
            return View("~/views/home/contact.cshtml");
        }
    }
}
