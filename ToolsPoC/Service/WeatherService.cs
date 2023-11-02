using System.Collections.Generic;
using ToolsPoC.DAL;
using ToolsPoC.Interfaces;
using ToolsPoC.Models;

namespace ToolsPoC.Service
{
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
    }
}
