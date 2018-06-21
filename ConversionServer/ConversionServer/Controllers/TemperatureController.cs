using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConversionServer.Controllers
{
    public class TemperatureController : Controller
    {
        public ActionResult ConvertToF()
        {
            return View(viewName:"TemperatureConversion", model: 0.0);
        }

        public ActionResult ConvertToF(double degreesC)
        {
            return View(viewName: "TemperatureConversion", model: (degreesC * 9 / 5 + 32));
        }
    }
}
