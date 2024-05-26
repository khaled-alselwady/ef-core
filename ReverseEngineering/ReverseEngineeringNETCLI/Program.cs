using ReverseEngineeringNETCLI.Data;

namespace ReverseEngineeringNETCLI
{
    internal class Program
    {
        // Step #1: Windows Terminal (Command Prompt) 

        // Step #2: Install Ef-Core tool globally
        //    dotnet tool install --global dotnet-ef    (new)
        //    dotnet tool update --global dotnet-ef     (to upgrade)

        // Step #3: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Run Command (Full)
        //    dotnet ef dbcontext scaffold '[Connection String]' [Provider]

        static void Main(string[] args)
        {
            foreach (var item in new AppDbContext().Speakers)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
