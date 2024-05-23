using Microsoft.EntityFrameworkCore;
using UsingContextFactory.Entities;

namespace UsingContextFactory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
