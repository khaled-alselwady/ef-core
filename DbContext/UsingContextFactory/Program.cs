using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsingContextFactory.Data;

namespace UsingContextFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json")
                 .Build();
            var connectionString = configuration.GetSection("ConnectionString").Value;

            var service = new ServiceCollection();

            service.AddDbContextFactory<AppDbContext>(options => options.UseSqlServer(connectionString));

            IServiceProvider serviceProvider = service.BuildServiceProvider();

            var contextFactory = serviceProvider.GetService<IDbContextFactory<AppDbContext>>();

            using (var context = contextFactory.CreateDbContext())
            {
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }
        }
    }
}
