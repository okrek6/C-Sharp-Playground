using C_Sharp_Playground.Models;
using C_Sharp_Playground.Models.Enums;
using C_Sharp_Playground.Service.Interfaces;
namespace C_Sharp_Playground.Service
{
    public class WeatherForecastService
    {
        IWeatherSummaryService weatherSummaryService;
        public WeatherForecastService() {

            weatherSummaryService = FactoryContainer.Register();
        }
        public IEnumerable<WeatherForecast> GetWeather(string x)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                //Summary = .GetSummary(x)
            })
           .ToArray();
        }
       
    }
}
