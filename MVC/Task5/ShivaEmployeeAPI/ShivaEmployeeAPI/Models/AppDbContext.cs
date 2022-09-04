
using Microsoft.EntityFrameworkCore;

namespace ShivaStudents.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                Name = "Shiva",
                Email = "Shiva@gmail.com",
                Salary = 41000,
              
                

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                Name = "Krishna",
                Email = "Krishna@gmail.com",
                Salary = 78000,
                
                

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                Name = "Anand",
                Email = "Anand@gmail.com",
                Salary = 98000,
                


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                Name = "Anita",
                Email = "Anita@gmail.com",
                Salary = 89000,
               
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                Name = "Shraddha",
                Email = "Sharaddh@gmail.com",
                Salary = 59000,
               


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                Name = "Amisha",
                Email = "Amisha@gmail.com",
                Salary = 70000,
                


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 7,
                Name = "Saurabh",
                Email = "saurabh@gmail.com",
                Salary = 48000,
              


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 8,
                Name = "Tilak",
                Email = "Tila@gmail.com",
                Salary = 47900,
              

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 9,
                Name = "Paru",
                Email = "Paru@gmail.com",
                Salary = 41007,
             

            });

        }
    }
}


