using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OverrideConfigurationUsingFluentAPI.Entities;

namespace OverrideConfigurationUsingFluentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("tblUsers");
            modelBuilder.Entity<Tweet>().ToTable("tblTweets");
            modelBuilder.Entity<Comment>().ToTable("tblComments");

            modelBuilder.Entity<Comment>().Property(p => p.ID).HasColumnName("CommentID");
            modelBuilder.Entity<Comment>().Property(p => p.CommentBy).HasColumnName("UserID");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetSection("ConnectionString").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
