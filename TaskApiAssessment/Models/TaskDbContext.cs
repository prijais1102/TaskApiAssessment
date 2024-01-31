using Microsoft.EntityFrameworkCore;

namespace TaskApiAssessment.Models
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
        public DbSet<Taskk> Tasks { get; set; } 
    }
}
