using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Iseu.UI.Models;

namespace Iseu.UI.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View("~views/login/login.cshtml");
        }

        [HttpPost]
        public ActionResult Login( )
        {
            return View("~views/login/login.cshtml");
        }
    }
}
