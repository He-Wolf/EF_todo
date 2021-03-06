using System.Collections.Generic;
using System.Threading.Tasks;
using EF_todo.Models;

namespace EF_todo.Interfaces
{
    public interface ITodoService
    {
        Task<List<TodoItem>> FindAllAsync();
        Task<TodoItem> FindByIdAsync(int id);
        Task CreateAsync(TodoItem todoItem);
        Task UpdateAsync(TodoItem todoItem);
        Task DeleteAsync(TodoItem todoItem);
    }
}