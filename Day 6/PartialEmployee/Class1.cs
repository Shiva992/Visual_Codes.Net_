using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Rishabh";
            emp.LastName = "Dora";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}