using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Szakdoga.Data;

namespace Szakdoga.Configurations.Entity
{
    public class TableSeedConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasData(
                new Table
                {
                    Id = 1,
                    Name = "Kis asztal",
                    SeatsNumber = 4,
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new Table
                {
                    Id = 2,
                    Name = "Közepes asztal",
                    SeatsNumber = 8,
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                },
                new Table
                {
                    Id = 3,
                    Name = "Nagy asztal",
                    SeatsNumber = 12,
                    CreatedDate = DateTime.Now,
                    LastModifyDate = DateTime.Now,
                    CreatedUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18",
                    LastModifyUserId = "43453ade-4415-4470-bdaa-4653ewq4dd18"
                }
            );
        }
    }
}
