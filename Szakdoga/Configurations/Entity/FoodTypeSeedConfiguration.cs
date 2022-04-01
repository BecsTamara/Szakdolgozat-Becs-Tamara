using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Szakdoga.Data;

namespace Szakdoga.Configurations.Entity
{
    public class FoodTypeSeedConfiguration : IEntityTypeConfiguration<FoodType>
    {
        public void Configure(EntityTypeBuilder<FoodType> builder)
        {
            builder.HasData(
                new FoodType
                {
                    Id = 1,
                    Name = "Leves",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodType
                {
                    Id = 2,
                    Name = "Ital",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodType
                {
                    Id = 3,
                    Name = "Fő étel",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodType
                {
                    Id = 4,
                    Name = "Desszert",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new FoodType
                {
                    Id = 5,
                    Name = "Savanyúság",
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                }
            );
        }
    }
}
