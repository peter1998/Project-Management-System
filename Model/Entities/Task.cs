using Project_Management_System.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Project_Management_System.Model.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public TrackType Type { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Assignee { get; set; }

        public Priority Priority { get; set; }

        public Status Status { get; set; }

        public int Estimate { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Project_Task>? Projects_Tasks { get; set; }
    }
}
