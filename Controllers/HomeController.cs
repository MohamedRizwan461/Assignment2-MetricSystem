using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;
using System;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TemperatureModel());
        }

       [HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Index(TemperatureModel model)
{
    if (!ModelState.IsValid)
    {
        ViewBag.CelsiusValue = null;
        return View(model);
    }

    double celsius = model.ToCelsius();
    ViewBag.CelsiusValue = celsius;

    return View(model);
}

    }
}
