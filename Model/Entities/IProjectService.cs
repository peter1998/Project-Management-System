
namespace Project_Management_System.Model.Entities
{
    public interface IProjectService
    {
        void Delete(Project prProject);
        List<Project> GetAll();
        List<Project> GetByName(string prName);
        Project Save(Project prProject);
        Project Update(Project prProject);
    }
}