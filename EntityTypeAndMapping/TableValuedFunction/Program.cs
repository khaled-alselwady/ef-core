using Microsoft.EntityFrameworkCore;
using TableValuedFunction.Data;
using TableValuedFunction.Entities;

namespace TableValuedFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var orderBillDetails = new AppDbContext().Set<OrderBill>()
                    .FromSqlInterpolated($"Select * From GetOrderBill({1})")
                    .ToList();

                foreach (var orderBill in orderBillDetails)
                {
                    Console.WriteLine(orderBill);
                }
            }
        }
    }
}
