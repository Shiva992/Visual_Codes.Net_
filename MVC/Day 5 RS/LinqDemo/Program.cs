using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeModel> employeeModels = new List<EmployeeModel>() {
            new EmployeeModel() { id = 1, Name = "Shiva", City = "Delhi", Country = "India" },
            new EmployeeModel()  { id = 2, Name = "Tilak", City = "Chandausi", Country = "India" },
            new EmployeeModel() { id = 3, Name = "Anita", City = "Moradabad", Country = "India" },
            new EmployeeModel() { id = 4, Name = "Anand", City = "Moradabad", Country = "India" },
            new EmployeeModel() { id = 5, Name = "RadhaKrishna", City = "Chandausi", Country = "India" },
            new EmployeeModel() { id = 6, Name = "RadheKrishhnaa", City = "Mathura", Country = "India" }};


            List<ProjectModel> pmodel = new List<ProjectModel>()
            {
                  new ProjectModel(){id=1,Projectame="Microsoft",ProjectCity="Chandausi"},
                  new ProjectModel(){id=1,Projectame="Google",ProjectCity="Moradabad"},
            };

            var result = from e in employeeModels
                         join p in pmodel
                         on e.City equals p.ProjectCity
                         select new
                         {
                             name = e.Name,
                             city = p.ProjectCity
                         };



            foreach(var item in result)
            {
                Console.Write(item.name + "--" + item.city);
                Console.WriteLine();
            }






            //List<EmployeeModel> em = EmployeeModel.GetAllEmployees();
            //var result = em.GroupBy(x => x.City);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key + " " + item.Count());
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
