using ExternalConfiguration.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExternalConfiguration.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
