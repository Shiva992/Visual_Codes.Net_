using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindEntities())
            {
                var result = context.Employees;
                foreach (var item in result)
                {
                    Console.WriteLine(item.EmployeeID);
                    Console.WriteLine(item.FirstName);
                }
                Console.ReadLine();
            }
        }
    }
}