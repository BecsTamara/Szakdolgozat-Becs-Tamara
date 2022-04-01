using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Szakdoga.Data;

namespace Szakdoga.Configurations.Entity
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                     Email = "boss@localhost.com",
                     NormalizedEmail = "BOSS@LOCALHOST.COM",
                     NormalizedUserName = "BOSS@LOCALHOST.COM",
                     UserName = "boss@localhost.com",
                     FirstName = "System",
                     LastName = "Boss",
                     Address = "8900, Zalegerszeg Teszt utca 3.",
                     LastLogin = DateTime.Now,
                     PasswordHash = hasher.HashPassword(null, "Admin123*"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "53543ce-822c-457d-9c2a-b5454f39b3b31",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     FirstName = "System",
                     LastName = "User",
                     LastLogin = DateTime.Now,
                     Address = "8976, Nemesnép Király utca 6.",
                     PasswordHash = hasher.HashPassword(null, "Admin123*"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}
