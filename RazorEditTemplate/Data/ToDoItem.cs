using System.ComponentModel.DataAnnotations;

namespace RazorEditTemplate.Data
{
    public class ToDoItem
    {
        [Required]
        public string Name { get; set; }

        public bool IsDone { get; set; }
    }
}
