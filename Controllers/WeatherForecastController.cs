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
       
        private IProjectService _IProjectService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProjectService prIProjectService)
        {
            _logger = logger;
            
            _IProjectService = prIProjectService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            //GET
            // List<Project> IProjects = _IProjectService.GetAll();
            //List<Project> IProjects = _IProjectService.GetByName("Quantum");
            //Add
            Project InewProject = new Project() { Name = "Orkaido" };
            _IProjectService.Save(InewProject);
            //Update
            Project IProjectToUpdate = _IProjectService.GetByName("Orkaido").FirstOrDefault();
            IProjectToUpdate.Name = "oRKAIDO Updated";
            _IProjectService.Update(IProjectToUpdate);
            //Delete
            Project IProjectToDelete = _IProjectService.GetByName("oRKAIDO Updated").FirstOrDefault();
            _IProjectService.Delete(IProjectToDelete);


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