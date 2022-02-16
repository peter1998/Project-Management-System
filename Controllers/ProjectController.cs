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
    [Route("[controller]")]
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
        public IEnumerable<Project> Get()
        {
            List<Project> IProjects = _IProjectService.GetAll();

            return IProjects;
        }

      
    }
}
