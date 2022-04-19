using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEditTemplate.Data;

namespace RazorEditTemplate.Pages
{
    public class EditPersonModel : PageModel
    {
        [BindProperty]
        public Person Person { get; set; }
        public IActionResult OnGet()
        {
            Person = new Person() { Age = 22, Name = "Tom", Colors = new List<string>() { "Red", "Yellow" } };
            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            var newdata = Person;
            return Page();
        }
    }
}
