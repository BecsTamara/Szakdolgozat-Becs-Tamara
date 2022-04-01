using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Szakdoga.Data;

namespace Szakdoga.Configurations.Entity
{
    public class FoodAllergyTypeSeedConfiguration : IEntityTypeConfiguration<FoodAllergyType>
    {
        public void Configure(EntityTypeBuilder<FoodAllergyType> builder)
        {
            builder.HasData(
                new FoodAllergyType
                {
                    Id = 1,
                    Name = "Laktóz",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodAllergyType
                {
                    Id = 2,
                    Name = "Diófélék",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodAllergyType
                {
                    Id = 3,
                    Name = "Glutén",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodAllergyType
                {
                    Id = 4,
                    Name = "Alkohol",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                }
            );
        }
    }
}
