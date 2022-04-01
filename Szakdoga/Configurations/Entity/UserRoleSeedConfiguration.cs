using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Szakdoga.Configurations.Entity
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>//Boss
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new IdentityUserRole<string>//Employee
                {
                    RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                    UserId = "53543ce-822c-457d-9c2a-b5454f39b3b31"
                }
            );
        }
    }
}
