using Day8.Models;
using Microsoft.EntityFrameworkCore;

namespace Day8.DB
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}