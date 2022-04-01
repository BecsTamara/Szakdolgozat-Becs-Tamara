using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models
{
    public class TableVM
    {
        public int? Id { get; set; }
        [Required]
        [Display(Name = "Asztal neve")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Székek száma")]
        public int SeatsNumber { get; set; }

        public string CreatedUserId { get; set; }
    }
}
