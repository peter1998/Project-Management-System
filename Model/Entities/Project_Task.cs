namespace Project_Management_System.Model.Entities
{
    public class Project_Task
    {
        public int ProjectId { get; set; }

        public Project? Project { get; set; }

        public int TaskId { get; set; }

        public ProjectTask? Task { get; set; }

        
    }
}
