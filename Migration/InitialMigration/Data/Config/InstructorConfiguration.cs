using InitialMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InitialMigration.Data.Config
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FName).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.LName).HasColumnType("varchar").HasMaxLength(50).IsRequired();

            builder.ToTable("Instructors");

            builder.HasData(LoadInstructors());
        }

        private List<Instructor> LoadInstructors()
        {
            return
            [
                new Instructor { Id = 1, FName = "Ahmed", LName = "Abdullah"},
                new Instructor { Id = 2, FName = "Yasmeen", LName = "Yasmeen"},
                new Instructor { Id = 3, FName = "Khalid", LName = "Hassan"},
                new Instructor { Id = 4, FName = "Nadia", LName = "Ali"},
                new Instructor { Id = 5, FName = "Ahmed", LName = "Abdullah"},
            ];
        }
    }
}
