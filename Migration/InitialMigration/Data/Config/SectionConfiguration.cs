using InitialMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialMigration.Data.Config
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.SectionName)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.HasOne(x => x.Course)
                   .WithMany(x => x.Sections)
                   .HasForeignKey(x => x.CourseId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Instructor)
                   .WithMany(x => x.Sections)
                   .HasForeignKey(x => x.InstructorId)
                   .IsRequired(false);

            builder.HasMany(x => x.Schedules)
                .WithMany(x => x.Sections)
                .UsingEntity<SectionSchedule>();

            builder.HasMany(x => x.Students)
                .WithMany(x => x.Sections)
                .UsingEntity<Enrollment>();

            builder.ToTable("Sections");

            builder.HasData(LoadSections());
        }

        private static List<Section> LoadSections()
        {
            return
            [
                new Section { Id = 1, SectionName = "S_MA1", CourseId = 1, InstructorId = 1},
                new Section { Id = 2, SectionName = "S_MA2", CourseId = 1, InstructorId = 2},
                new Section { Id = 3, SectionName = "S_PH1", CourseId = 2, InstructorId = 1},
                new Section { Id = 4, SectionName = "S_PH2", CourseId = 2, InstructorId = 3},
                new Section { Id = 5, SectionName = "S_CH1", CourseId = 3, InstructorId =2},
                new Section { Id = 6, SectionName = "S_CH2", CourseId = 3, InstructorId = 3},
                new Section { Id = 7, SectionName = "S_BI1", CourseId = 4, InstructorId = 4},
                new Section { Id = 8, SectionName = "S_BI2", CourseId = 4, InstructorId = 5},
                new Section { Id = 9, SectionName = "S_CS1", CourseId = 5, InstructorId = 4},
                new Section { Id = 10, SectionName = "S_CS2", CourseId = 5, InstructorId = 5},
                new Section { Id = 11, SectionName = "S_CS3", CourseId = 5, InstructorId = 4}
            ];
        }
    }
}
