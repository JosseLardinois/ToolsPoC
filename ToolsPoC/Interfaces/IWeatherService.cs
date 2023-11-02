using ToolsPoC.Models;

namespace ToolsPoC.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetForecasts();
    }
}
