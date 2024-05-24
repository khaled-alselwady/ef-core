using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OverrideConfigurationByGroupingConfiguration.Data.Config;
using OverrideConfigurationByGroupingConfiguration.Entities;

namespace OverrideConfigurationByGroupingConfiguration.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // individual call
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new TweetConfiguration().Configure(modelBuilder.Entity<Tweet>());
            new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());
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
