using C_Sharp_Playground.Models.Enums;
using C_Sharp_Playground.Service.Interfaces;

namespace C_Sharp_Playground.Service
{
    public class WeatherSummaryService : IWeatherSummaryService
    {
        public WeatherSummary GetSummary(string x)
        {
            if (x == null)
            {
                throw new ArgumentNullException("x needs value");
            }
            WeatherSummary summary = WeatherSummary.Warm;
            return summary;
        }
    }
}
