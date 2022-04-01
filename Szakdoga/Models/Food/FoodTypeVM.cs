using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models.Food
{
    public class FoodTypeVM
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Étel típus")]
        public string Name { get; set; }
    }
}
