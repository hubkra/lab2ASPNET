using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        [Display(Name = "imie: ")]
        public string Name { get; set; }
        [Display(Name = "data urodzenia: ")]
        public string Description { get; set; }
        
    }
}
