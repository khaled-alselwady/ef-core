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
        }
    }
}
