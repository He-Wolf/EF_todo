using Microsoft.EntityFrameworkCore;
using EF_todo.Models;

namespace EF_todo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
