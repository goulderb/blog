using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.API.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]/[action]")]
public class WeatherController : ControllerBase
{
    private static readonly string[] _summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<WeatherController> _logger;

    public WeatherController(ILogger<WeatherController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Forecast()
    {
        return Enumerable
            .Range(1, 5)
            .Select(
                index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = _summaries[Random.Shared.Next(_summaries.Length)]
                    }
            )
            .ToArray();
    }
}
