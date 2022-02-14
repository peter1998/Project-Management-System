using Microsoft.AspNetCore.Mvc;
using Project_Management_System.DependencyInjection;
using Project_Management_System.Model.Entities;

namespace Project_Management_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IConsoleWriter _IConsoleWriter;
        private IProjectService _IProjectService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConsoleWriter prIConsoleWriter, IProjectService prIProjectService)
        {
            _logger = logger;
            _IConsoleWriter = prIConsoleWriter;
            _IProjectService = prIProjectService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            //Dependency Injection
            // _IConsoleWriter.Write();

            List<Project> projects;


            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}