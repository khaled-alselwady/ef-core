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

            builder.HasOne(x => x.Schedule)
                .WithMany(x => x.Sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();

            builder.HasMany(x => x.Students)
                .WithMany(x => x.Sections)
                .UsingEntity<Enrollment>();

            builder.ToTable("Sections");
        }
    }
}
