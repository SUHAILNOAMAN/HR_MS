using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model
{
    public static class SeedDepatment
    {
        public static void Seeddepartment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    ID = 1,
                    Name = "Suhil noman",
                    type = "Partial"
                    
                }


            );
        }
    }
}
