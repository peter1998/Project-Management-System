using Microsoft.EntityFrameworkCore;
using Project_Management_System.Model.Entities;
using ProjectTask = Project_Management_System.Model.Entities.ProjectTask;

namespace Project_Management_System
{
    public class AppDataContext : DbContext
    {

        public AppDataContext(DbContextOptions<AppDataContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project_Task>().HasKey(pt => new
            {
                pt.ProjectId,
                pt.TaskId
            });

            modelBuilder.Entity<Project_Task>()
                .HasOne(p => p.Project)
                .WithMany(pt => pt.Projects_Tasks)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<Project_Task>().HasOne(t => t.Task)
                .WithMany(pt => pt.Projects_Tasks).HasForeignKey(t => t.TaskId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }

        public DbSet<Project_Task> Projects_Tasks { get; set; }
    }
}
