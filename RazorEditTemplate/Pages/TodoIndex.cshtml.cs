using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEditTemplate.Data;

namespace RazorEditTemplate.Pages
{
    public class TodoIndexModel : PageModel
    {
        public List<ToDoItem> ToDoItems { get; set; }
        public IActionResult OnGet()
        {
           ToDoItems = new List<ToDoItem>()
            {
                new ToDoItem(){ Name="AA", IsDone=true},
                new ToDoItem(){ Name="BB", IsDone=false}
            };

            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }

            var isvalid = ModelState.IsValid;
            var newdata = ToDoItems;
            return Page();
        }

    }
}
