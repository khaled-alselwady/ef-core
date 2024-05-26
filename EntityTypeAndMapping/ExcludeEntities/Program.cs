using ExcludeEntities.Data;

namespace ExcludeEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"{product.Name} \t\n...... loaded at " +
                    $"{product.Snapshot.LoadedAt:yyyy-MM-dd hh:mm}" +
                    $"\nVersion: {product.Snapshot.Version}");
                }
            }
        }
    }
}
