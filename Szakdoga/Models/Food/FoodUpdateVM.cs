using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Szakdoga.Data;

namespace Szakdoga.Models.Food
{
    public class FoodUpdateVM
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Étel neve")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Az étel típusa")]
        public int FoodTypeId { get; set; }
        public IEnumerable<SelectListItem>? FoodTypes { get; set; }
        [Required]
        [Display(Name = "Korhatáros")]
        public bool Adult { get; set; }
        [Required]
        [Display(Name = "Allergiák")]
        public List<int> Allergies { get; set; }
        public IEnumerable<int>? AllAllergies { get; set; }
        [Required]
        [Display(Name = "Az étel ára")]
        public int Price { get; set; }
        [Display(Name = "Megjegyzés")]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Elérhető")]
        public bool Enabled { get; set; }
        public string CreatedUserId { get; set; }
    }
}
