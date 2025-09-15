using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View(new TemperatureModel());
        }

    [HttpPost]
public IActionResult Fahrenheit(TemperatureModel model)
{if (ModelState.IsValid)
{
    ViewBag.CelsiusValue = model.ToCelsius();

    }
    
    return View(model);

        }
    }
}