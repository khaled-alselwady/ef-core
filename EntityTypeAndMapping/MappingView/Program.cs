using MappingView.Data;

namespace MappingView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in context.OrderWithDetailsView)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
