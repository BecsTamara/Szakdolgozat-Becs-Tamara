using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models.Food
{
    public class FoodAllergyTypeVM
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Étel allergia")]
        public string Name { get; set; }
    }
}
