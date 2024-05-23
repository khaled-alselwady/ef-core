using DbContextAndConcurrency.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbContextAndConcurrency.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
