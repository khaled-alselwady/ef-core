using InitialMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialMigration.Data.Config
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            // builder.Property(x => x.Name).HasMaxLength(255).IsRequired(); // nvarchar(255)
            builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(255).IsRequired(); // varchar(255)
            builder.Property(x => x.Price).HasPrecision(15, 2);

            builder.ToTable("Courses");
        }
    }
}
