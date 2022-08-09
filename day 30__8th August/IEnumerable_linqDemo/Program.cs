using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_linq
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string Gender { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID=1,name="Divya",Gender="Female"},
                new Student(){ID=1,name="Supriya",Gender="Female"},
                new Student(){ID=1,name="Anmol",Gender="male"},
                new Student(){ID=1,name="Rishabh",Gender="male"}

            };
            IEnumerable<Student> QuerySyntax = from std in studentList
                                               where std.Gender == "Female"
                                               select std;

            foreach (var student in QuerySyntax)
            {
                Console.WriteLine($"ID:{student.ID} Name:{student.name}");
            }
            Console.ReadKey();
        }
    }
}