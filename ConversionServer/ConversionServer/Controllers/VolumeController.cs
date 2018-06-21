using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConversionServer.Controllers
{
    public class VolumeController : Controller
    {
        
        [HttpPost]
        public ActionResult ConvertToPints(double inputNumber)
        {
            return View(viewName: "VolumeConversion", model: (inputNumber/8.0));
        }

        [HttpPost]
        public ActionResult ConvertToGallons(double inputNumber2)
        {
            return View(viewName: "VolumeConversion", model: (inputNumber2 * 8.0));
        }

    }
}
