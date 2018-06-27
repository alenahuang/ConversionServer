using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConversionServer.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConversionServer.Controllers
{
    public class TemperatureController : Controller
    {
        TemperatureModel model = new TemperatureModel();

        public ActionResult TemperatureConversion()
        {
            model.CelsiusInput = 0;
            model.FahrenheitInput = 0;
            model.CelsiusOutput = 0;
            model.FahrenheitOutput = 0;
            return View(viewName:"TemperatureConversion", model: model);
        }

        [HttpPost]
        public ActionResult ConvertTemperature(double degreesC, double degreesF)
        {
            model.CelsiusInput = degreesC;
            model.FahrenheitInput = degreesF;
            model.CelsiusOutput = degreesF * 9 / 5 + 32;
            model.FahrenheitOutput = (degreesC - 32) * 5 / 9;
            return View(viewName: "TemperatureConversion", model: model);
        }
    }
}
