using IncludeEntities.Data;
using Microsoft.EntityFrameworkCore;

namespace IncludeEntities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                //var orderDetails = context.OrderDetails
                //    .Where(od => od.OrderId == 1)
                //    .ToList();

                var orderDetails = context.Orders
                    .Include(o => o.OrderDetails)?
                    .FirstOrDefault(o => o.Id == 1)?.OrderDetails;

                Console.WriteLine($"Items Count In Order 1 = {orderDetails?.Count}");

                //var auditEntry = new AuditEntry { UserName = "issam", Action = "read order count" };

                //context.Set<AuditEntry>().Add(auditEntry);
                //context.SaveChanges();
            }
        }
    }
}
