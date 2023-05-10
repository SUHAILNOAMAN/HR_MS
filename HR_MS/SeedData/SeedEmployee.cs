using Microsoft.EntityFrameworkCore;
using HR_MS.Model;

namespace HR_MS.Model   
{
    public static class SeedEmployee
    {
        public static void Seedemployee(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    ID = 1,
                    Name = "Suhil noman",
                    Address = "Sana'a",
                    Emial = "Suhilnoman@gmail.com",
                    PhoneNumber="7535424242"
                    
                }
            );
        }
    }
}
