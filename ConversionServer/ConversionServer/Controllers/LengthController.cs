﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConversionServer.Controllers
{
    public class TestController : Controller
    {
        // GET: /<controller>/
        public ActionResult LengthConversion()
        {
            return View(viewName: "LengthConversion");
        }
        [HttpPost]
        public ActionResult Conversion(ConversionServer.Views.Length.LengthModel lengthInStuff)
        {

        }
    }
}
