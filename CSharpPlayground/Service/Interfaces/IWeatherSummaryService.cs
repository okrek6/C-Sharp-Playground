using C_Sharp_Playground.Models.Enums;

namespace C_Sharp_Playground.Service.Interfaces
{
    public interface IWeatherSummaryService
    {
        public WeatherSummary GetSummary(string x);

    }
}