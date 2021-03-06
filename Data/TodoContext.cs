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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .HasData
                (
                    new TodoItem { Id = 1, Title = "Cleaning", Description = "to clean the house", IsComplete = true },
                    new TodoItem { Id = 2, Title = "Groceries", Description = "to buy healthy food", IsComplete = false },
                    new TodoItem { Id = 3, Title = "Excercise", Description = "to do 100 push-ups", IsComplete = false }
                );
        }

        public DbSet<EF_todo.Models.TodoItem> TodoItem { get; set; }
    }
}
