using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel;
using System;

using HR_MS.Model;

namespace HR_MS.DBContext
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
        {
        }
        public DataBaseContext(DbContextOptions _options) //: base(options)
        {
            
            

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=H_R;Integrated Security=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seedemployee();
            modelBuilder.Seeddepartment();
            modelBuilder.Seedsalary();



        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Salary> Salari { get; set; }
        public virtual DbSet<Department> Departments { get; set; }



    }
}
 