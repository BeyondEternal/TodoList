using Microsoft.EntityFrameworkCore;

namespace TodoList.Server.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoList.Shared.Models.TodoItem> TodoItems { get; set; }
    }
}
