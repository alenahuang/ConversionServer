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
        public ActionResult LengthConversion()
        {
            return View(viewName: "LengthConversion");
        }
        [HttpPost]
        public ActionResult Conversion(double inFeet, double inYards)
        {
            
        }
        DigitalModel model = new DigitalModel();

        public ActionResult LengthConversion()
        {
            model.MegabyteInput = 0;
            model.MegabyteOutput = 0;
            model.GigabyteInput = 0;
            model.GigabyteOutput = 0;
            return View(viewName: "DigitalConversion", model: model);
        }

        [HttpPost]
        public ActionResult Conversion(double inFeet, double inYards)
        {
            model.MegabyteInput = MegaBytes;
            model.GigabyteOutput = MegaBytes / 1024;
            model.GigabyteInput = GigaBytes;
            model.MegabyteOutput = GigaBytes * 1024;
            return View(viewName: "DigitalConversion", model: model);
        }
}
