using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConversionServer.Models;

namespace ConversionServer.Controllers
{
    public class DigitalController : Controller
    {
        DigitalModel model = new DigitalModel();

        public ActionResult DigitalConversion()
        {
            model.inputNumber = 0;
            model.outputNumber = 0;
            return View(viewName: "DigitalConversion", model: model);
        }
    }
}