using Microsoft.AspNetCore.Identity;

namespace Szakdoga.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLogin { get; set; }
        public string Address { get; set; }
    }
}
