using C_Sharp_Playground.Models.Enums;

namespace C_Sharp_Playground.Models
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public WeatherSummary? Summary { get; set; }
    }
}