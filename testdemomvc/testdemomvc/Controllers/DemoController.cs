﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testdemomvc.Controllers
{
    public class DemoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

    }
}