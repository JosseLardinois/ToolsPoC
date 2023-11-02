using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToolsPoC.Interfaces;
using ToolsPoC.Models;
using ToolsPoC.Service;

namespace ToolsPoC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherService.GetForecasts();
        }
    }
}
