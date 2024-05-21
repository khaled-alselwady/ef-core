using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SetupEFCoreModel
{
    public class AppDBContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetSection("ConnectionString").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
