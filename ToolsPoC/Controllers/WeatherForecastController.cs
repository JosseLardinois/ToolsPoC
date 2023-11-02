using Microsoft.AspNetCore.Mvc;
using ToolsPoC.Interfaces;
using ToolsPoC.Models;

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

    // Added to increase code complexity and coupling
    [HttpGet("GetDetailedForecasts")]
    public IEnumerable<WeatherForecast> GetDetailedForecasts()
    {
        var forecasts = _weatherService.GetForecasts();
        // Complex logic can be added here
        return forecasts;
    }

    // Added to increase code duplication
    [HttpGet("GetDuplicateForecasts")]
    public IEnumerable<WeatherForecast> GetDuplicateForecasts()
    {
        return _weatherService.GetForecasts();
    }
    [HttpGet("GetDuplicateForecasts")]
    public IActionResult GetWeatherComment()
    {
        return Ok(_weatherService.GetSpecificForecast());
    }

}
