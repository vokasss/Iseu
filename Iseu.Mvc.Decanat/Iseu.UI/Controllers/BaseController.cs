﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Iseu;

namespace Iseu.UI.Controllers
{
    public class BaseController : Controller
    {
        public string Usersss
        {
            get
            {
                return this.User.Identity.Name ;
            }
        }
    }
}