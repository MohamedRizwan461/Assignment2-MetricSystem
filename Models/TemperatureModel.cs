using System;
using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Display(Name = "Fahrenheit Value")]
[Required(ErrorMessage = "Fahrenheit value is required")]
public double? Fahrenheit { get; set; }  // input value


        [Display(Name = "Celsius Value")]
        public double? Celsius { get; set; }     // output value (from ViewBag)

        // Calculation must live in the model
        public double ToCelsius()
        {
            if (!Fahrenheit.HasValue)
                throw new InvalidOperationException("Fahrenheit must have a value.");
            return (Fahrenheit.Value - 32.0) * 5.0 / 9.0;
        }
    }
}
