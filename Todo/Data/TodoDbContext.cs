using Microsoft.EntityFrameworkCore;
using Todo.Models.Domain;
using Task = Todo.Models.Domain.Task;

namespace Todo.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
