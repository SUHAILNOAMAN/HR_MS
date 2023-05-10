using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model
{
    public static class SeedSalary
    {
        public static void Seedsalary(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salary>().HasData(
                new Salary
                {
                    ID = 1,
                    amt = "Suhil noman",
                    type = "Devloper"
                }
            );
        }
    }
}
