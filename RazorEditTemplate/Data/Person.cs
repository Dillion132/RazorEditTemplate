using System.ComponentModel.DataAnnotations;

namespace RazorEditTemplate.Data
{
    public class Person
    {
        public List<string> Colors { get; set; }
        public int Age { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
