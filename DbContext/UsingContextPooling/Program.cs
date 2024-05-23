using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsingContextPooling.Data;

namespace UsingContextPooling
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

            service.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(connectionString));

            IServiceProvider serviceProvider = service.BuildServiceProvider();

            using (var context = serviceProvider.GetService<AppDbContext>())
            {
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }
            }
        }
    }
}
