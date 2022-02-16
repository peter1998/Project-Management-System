using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Management_System;
using Project_Management_System.Model.Entities;

namespace Project_Management_System.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly AppDataContext _context;

        private IProjectService _IProjectService;

        public ProjectController(IProjectService prIProjectService)
        {
            _IProjectService = prIProjectService;
        }

        // GET: 
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Project> IResult = _IProjectService.GetAll();

            return Ok(IResult);
        }

        [HttpGet]
        public IActionResult Search()
        {
            List<Project> IResult = _IProjectService.GetAll();

            return Ok(IResult);
        }

        [HttpPut]
        public IActionResult Update(Project prProject)
        {

            return Ok(_IProjectService.Update(prProject));
        }

        [HttpPost]
        public IActionResult Save(Project prProject)
        {
            return Ok(_IProjectService.Save(prProject));
        }

        [HttpDelete]
        public IActionResult Delete(Project prProject)
        {

            _IProjectService.Delete(prProject);
            return Ok();
        }
    }
}
