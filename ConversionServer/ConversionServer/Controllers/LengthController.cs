using System;
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
        ConversionServer.Views.Length.LengthModel model = new ConversionServer.Views.Length.LengthModel();
        public ActionResult LengthConversion() => View(viewName: "DigitalConversion", model: model);
        [HttpPost]
        public ActionResult Conversion(double inFeet, double inYards)
        {
            model.setAll(inFeet, inYards * 3, inYards, inYards / 3);
            return View(viewName: "DigitalConversion", model: model);
        }
    }
}
