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
            //Linq query to fetch all students with gender male
            IQueryable<Student> MethodSyntax =  studentList.AsQueryable()
                                               .Where (std=> std.Gender == "male");
                                            

            foreach (var student in MethodSyntax)
            {
                Console.WriteLine($"ID:{student.ID} Name:{student.name}");
            }
            Console.ReadKey();
        }
    }
}