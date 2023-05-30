using C_Sharp_Playground.Models;
using C_Sharp_Playground.Service;
using Microsoft.AspNetCore.Mvc;

namespace CSharpPlayground.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        WeatherForecastService service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            service = new WeatherForecastService();

            _logger = logger;
        }
        /// <summary>
        /// Gets weather
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get(int x)
        {
            //Random.Shared.Next(1, 10)
            return service.GetWeather("test");
        }
    }
}