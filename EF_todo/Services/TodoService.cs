using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_todo.Interfaces;
using EF_todo.Models;
using EF_todo.Data;

namespace EF_todo.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _context;

        public TodoService(TodoContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> FindAllAsync()
        {
            return await _context.TodoItem.ToListAsync();
        }

        public async Task<TodoItem> FindByIdAsync(int id)
        {
            return await _context.TodoItem.FindAsync(id);
        }

        public async Task CreateAsync(TodoItem todoItem)
        {
            _context.TodoItem.Add(todoItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TodoItem todoItem)
        {
            _context.Entry(todoItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TodoItem todoItem)
        {
            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();
        }
    }
}   