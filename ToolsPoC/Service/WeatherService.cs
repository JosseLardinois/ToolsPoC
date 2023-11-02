using ToolsPoC.Interfaces;
using ToolsPoC.Models;

public class WeatherService : IWeatherService
{
    private readonly WeatherDAL _weatherDAL;

    public WeatherService()
    {
        _weatherDAL = new WeatherDAL();
    }

    public IEnumerable<WeatherForecast> GetForecasts()
    {
        return _weatherDAL.GetForecasts();
    }

    // Added to increase code complexity
    public IEnumerable<WeatherForecast> GetComplexForecasts()
    {
        // Complex logic can be added here
        return _weatherDAL.GetForecasts();
    }

    // Added to increase code duplication
    public IEnumerable<WeatherForecast> GetDuplicateForecasts()
    {
        return _weatherDAL.GetForecasts();
    }

 public string GetSpecificForecast()
    {
        var forecasts = _weatherDAL.GetForecasts();

        if (!forecasts.Any())
        {
            return "No forecasts available";
        }

        foreach (var item in forecasts)
        {
            if (item.TemperatureC < 10)
            {
                return "Cold weather";
            }
            else if (item.TemperatureC == 10)
            {
                return "Chilly weather";
            }
            else if (item.TemperatureC == 15)
            {
                return "Not that hot";
            }
            else if (item.TemperatureC == 20)
            {
                return "Pleasant weather";
            }
            else if (item.TemperatureC == 25)
            {
                return "Hot weather";
            }
            else if (item.TemperatureC == 30)
            {
                return "Very hot weather";
            }
            else if (item.TemperatureC == 30)
            {
                return "Very hot weather";
            }
        }

        return "No clue what weather it is";
    }
}
