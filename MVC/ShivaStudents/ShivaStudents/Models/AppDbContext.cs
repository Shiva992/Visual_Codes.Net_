using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ShivaStudents.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentID = 1, DepartmentName = "IT Department" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentID = 2, DepartmentName = "Account Department" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentID = 3, DepartmentName = "Marketing Department" });

            //seed pies

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                Name = "Shiva",
                Email = "Shiva@gmail.com",
                Salary = 41000,
                DepartmentID = 1,
                City = "Moradabad",
                Gender = "Female"

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                Name = "Krishna",
                Email = "Krishna@gmail.com",
                Salary = 78000,
                DepartmentID = 1,
                City = "Delhi",
                Gender = "Male"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                Name = "Anand",
                Email = "Anand@gmail.com",
                Salary = 98000,
                DepartmentID = 1,
                City = "Moradabad",
                Gender = "Male"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                Name = "Anita",
                Email = "Anita@gmail.com",
                Salary = 89000,
                DepartmentID = 2,
                City = "Goa",
                Gender = "Female"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                Name = "Shraddha",
                Email = "Sharaddh@gmail.com",
                Salary = 59000,
                DepartmentID = 2,
                City = "Pune",
                Gender = "Female"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                Name = "Amisha",
                Email = "Amisha@gmail.com",
                Salary = 70000,
                DepartmentID = 2,
                City = "Mumbai",
                Gender = "Female"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 7,
                Name = "Saurabh",
                Email = "saurabh@gmail.com",
                Salary = 48000,
                DepartmentID = 3,
                City = "Gurgaon",
                Gender = "Male"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 8,
                Name = "Tilak",
                Email = "Tila@gmail.com",
                Salary = 47900,
                DepartmentID = 3,
                City = "Banaras",
                Gender = "Male"


            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 9,
                Name = "Paru",
                Email = "Paru@gmail.com",
                Salary = 41007,
                DepartmentID = 3,
                City = "Amroha",
                Gender = "Female"


            });

        }
    }
}


