using InitialMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialMigration.Data.Config
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.OfficeName)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(x => x.OfficeLocation)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.ToTable("Offices");

            builder.HasData(LoadOffices());
        }

        private static List<Office> LoadOffices()
        {
            return
            [
                    new Office { Id = 1, OfficeName = "Off_05", OfficeLocation = "building A"},
                    new Office { Id = 2, OfficeName = "Off_12", OfficeLocation = "building B"},
                    new Office { Id = 3, OfficeName = "Off_32", OfficeLocation = "Administration"},
                    new Office { Id = 4, OfficeName = "Off_44", OfficeLocation = "IT Department"},
                    new Office { Id = 5, OfficeName = "Off_43", OfficeLocation = "IT Department"}
            ];
        }
    }
}
