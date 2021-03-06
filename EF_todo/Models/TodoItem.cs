  
using System.ComponentModel.DataAnnotations;

namespace EF_todo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}