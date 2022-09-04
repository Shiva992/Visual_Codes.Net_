using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)//main 1
        {
            List<EmployeeModel2> employeeModels = new List<EmployeeModel2>() {//object 1st table
            new EmployeeModel2() { id = 1, Name = "Shiva", City = "Delhi", Country = "India" },
            new EmployeeModel2()  { id = 2, Name = "Tilak", City = "Chandausi", Country = "India" },
            new EmployeeModel2() { id = 3, Name = "Anita", City = "Moradabad", Country = "India" },
            new EmployeeModel2() { id = 4, Name = "Anand", City = "Moradabad", Country = "India" },
            new EmployeeModel2() { id = 5, Name = "RadhaKrishna", City = "Chandausi", Country = "India" },
            new EmployeeModel2() { id = 6, Name = "RadheKrishhnaa", City = "Mathura", Country = "India" }};//value


            List<ProjectModel> pmodel = new List<ProjectModel>()//2nd table
            {
                  new ProjectModel(){id=1,ProjectName="Microsoft",ProjectCity="Chandausi"},
                  new ProjectModel(){id=1,ProjectName="Google",ProjectCity="Moradabad"},
            };

            var result = from e in employeeModels//e= em
                         join p in pmodel//p-pm
                         on e.City equals p.ProjectCity 
                         select new

                         {
                             name = e.Name,
                             city = p.ProjectCity,
                             project=p.ProjectName
                         };

            foreach (var item in result)
            {
                Console.Write(item.name + "--" + item.city+"--"+item.project);
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
