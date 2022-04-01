using System.ComponentModel.DataAnnotations;

namespace Szakdoga.Models
{
    public class EmployeeVM
    {
        public string? Id { get; set; }
        [Display(Name = "Felhasználó név")]
        public string UserName { get; set; }
        [Display(Name = "Keresztnév")]
        public string FirstName { get; set; }
        [Display(Name = "Vezetéknév")]
        public string LastName { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
