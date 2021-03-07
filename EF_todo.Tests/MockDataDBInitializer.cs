using EF_todo.Models;
using EF_todo.Data;

namespace EF_todo.Tests
{
    public class MockDataDBInitializer
    {
        public MockDataDBInitializer()
        {
        }
  
        public void Seed(TodoContext context)  
        {
            if (context != null)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            context.TodoItem.AddRange(
                new TodoItem { Id = 1, Title = "Cleaning", Description = "to clean the house", IsComplete = true },
                new TodoItem { Id = 2, Title = "Groceries", Description = "to buy healthy food", IsComplete = false },
                new TodoItem { Id = 3, Title = "Excercise", Description = "to do 100 push-ups", IsComplete = false } 
            );
            context.SaveChanges();
        }
    }
}