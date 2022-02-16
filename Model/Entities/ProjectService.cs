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
            var linq = from projects in _context.Projects select projects;

            if (!string.IsNullOrEmpty(prName))
            {
                linq = linq.Where(x => x.Name.ToUpper().Contains(prName.ToUpper()));
            }

            return linq.ToList();
        }

        public Project Save(Project prProject)
        {
            _context.Projects.Add(prProject);
            _context.SaveChanges();
            return prProject;
        }

        public Project Update(Project prProject)
        {
            Project IProjectFromDb = _context.Projects.First(x => x.Id == prProject.Id);
            _context.Entry(IProjectFromDb).CurrentValues.SetValues(prProject);
            _context.SaveChanges();
            return prProject;
        }

        public void Delete(Project prProject)
        {
            _context.Entry(prProject).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
