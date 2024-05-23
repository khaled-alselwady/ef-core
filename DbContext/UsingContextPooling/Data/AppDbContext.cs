using Microsoft.EntityFrameworkCore;
using UsingContextPooling.Entities;

namespace UsingContextPooling.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
