﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Buddy.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
