using BasicSetup.Data;

namespace BasicSetup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine(product?.Name);
                }
            }
        }
    }
}
