using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Iseu.Core.Repositories;

namespace Iseu.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var user = this.User;
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            StudentsRepository stud = new StudentsRepository(new Context());
            return View("~/views/home/index.cshtml", stud.GetAll());
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
