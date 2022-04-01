using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Szakdoga.Data;

namespace Szakdoga.Models
{
    public class FoodCreateVM
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Étel neve")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Az étel típusa")]
        public int FoodTypeId { get; set; }
        public SelectList? FoodTypes { get; set; }
        [Required]
        [Display(Name = "Korhatáros")]
        public bool Adult { get; set; }
        [Required]
        [Display(Name = "Allergiák")]
        public List<int> Allergies { get; set; }
        public SelectList? FoodAllergyTypes { get; set; }
        [Required]
        [Display(Name = "Az étel ára")]
        public int Price { get; set; }
        [Display(Name = "Megjegyzés")]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Elérhető")]
        public bool Enabled { get; set; }
    }
}
