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
            model.MegabyteInput = 0;
            model.MegabyteOutput = 0;
            model.GigabyteInput = 0;
            model.GigabyteOutput = 0;
            return View(viewName: "DigitalConversion", model: model);
        }

        [HttpPost]
        public ActionResult ConvertData(double MegaBytes, double GigaBytes)
        {
            model.MegabyteInput = MegaBytes;
            model.GigabyteOutput = MegaBytes / 1024;
            model.GigabyteInput = GigaBytes;
            model.MegabyteOutput = GigaBytes * 1024;
            return View(viewName: "DigitalConversion", model: model);
        }
    }
}