using BasicSetup.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BasicSetup.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable(name: "Products", schema: "Inventory")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Order>()
                .ToTable(name: "Orders", schema: "Sales")
                .HasKey(o => o.Id);

            modelBuilder.Entity<OrderDetail>()
                .ToTable(name: "OrderDetails", schema: "Sales")
                .HasKey(o => o.Id);

            // modelBuilder.HasDefaultSchema("Sales");

            base.OnModelCreating(modelBuilder);
        }

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
