using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class TemperatureModel
    {
        [Required(ErrorMessage = "Fahrenheit value is required.")]
        [Range(-459.67, double.MaxValue, ErrorMessage = "Value must be at least absolute zero (-459.67).")]
        public double? Fahrenheit { get; set; }

        public double? Celsius { get; set; }

        public double? ToCelsius()
        {
            if (Fahrenheit.HasValue)
            {
                return (Fahrenheit.Value - 32.0) * 5.0 / 9.0;
            }
            return null;
        }
    }
}