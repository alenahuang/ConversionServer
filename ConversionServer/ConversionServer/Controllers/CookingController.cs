using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConversionServer.Models;

namespace ConversionServer.Controllers
{
    public class CookingController : Controller
    {
        CookingModel model = new CookingModel();

        public IActionResult CookingConversion()
        {
            model.TeaspoonInput = 0;
            model.TeaspoonOutput = 0;
            model.TablespoonInput = 0;
            model.TeaspoonOutput = 0;
            return View(viewName: "CookingConversion", model: model);
        }

        [HttpPost]
        public ActionResult ConvertData(double teaspoons, double tablespoons)
        {
            model.TeaspoonInput = teaspoons;
            model.TablespoonOutput = teaspoons * 3;
            model.TablespoonInput = tablespoons;
            model.TeaspoonOutput =  tablespoons / 3;
            return View(viewName: "CookingConversion", model: model);
        }
    }
}
