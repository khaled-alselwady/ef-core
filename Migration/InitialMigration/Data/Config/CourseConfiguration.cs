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

            builder.HasData(LoadCourses());
        }

        private static List<Course> LoadCourses()
        {
            return
            [
                new Course { Id = 1, Name = "Mathematics", Price = 1000m},
                new Course { Id = 2, Name = "Physics", Price = 2000m},
                new Course { Id = 3, Name = "Chemistry", Price = 1500m},
                new Course { Id = 4, Name = "Biology", Price = 1200m},
                new Course { Id = 5, Name = "CS-50", Price = 3000m},
            ];
        }
    }
}
