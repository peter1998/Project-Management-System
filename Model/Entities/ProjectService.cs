namespace Project_Management_System.Model.Entities
{
    public class ProjectService : IProjectService
    {
        public AppDataContext _context { get; set; }

        public ProjectService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }

        public List<Project> GetAll()
        {
            return _context.Projects.ToList();
        }

        public List<Project> GetByName(string prName)
        {
            return null;
        }

        public Project Save(Project prProject)
        {
            return null;
        }

        public Project Update(Project prProject)
        {
            return null;
        }

        public void Delete(Project prProject)
        {

        }
    }
}
