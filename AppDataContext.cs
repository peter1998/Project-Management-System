using Microsoft.EntityFrameworkCore;
using Project_Management_System.Model.Entities;

namespace Project_Management_System
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            :base(options)
        {

        }
        
        public DbSet<Project> Projects { get; set; }
    }
}
