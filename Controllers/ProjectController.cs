using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Management_System.Model.Entities;

namespace Project_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {

        private readonly AppDataContext _context;
        public ProjectController(AppDataContext context)
        {
            _context= context;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {
            return await _context.Projects.ToListAsync();
        }

        // GET: api/Project/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetDCandidate(int id)
        {
            var Project = await _context.Projects.FindAsync(id);

            if (Project == null)
            {
                return NotFound();
            }

            return Project;
        }

    }
}
