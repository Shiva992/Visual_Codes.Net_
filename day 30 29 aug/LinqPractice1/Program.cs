using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linqpractice
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abhi", "Wicked", "Harsh", "Aakash" };
            //Linq query
            var nameswithA = from name in names
                             where name.Contains('a')
                             select name;


            foreach (string s in nameswithA)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine();

            Student[] studentArray =
            {
                new Student(){StudentID=1,Name="Abhi",Age=18},
                new Student(){StudentID=2,Name="Harsh",Age=21},
                new Student(){StudentID=3,Name="Aakash",Age=23},
                new Student(){StudentID=4,Name="Devraj",Age=26},
                new Student(){StudentID=5,Name="Bhanu",Age=32},
                new Student(){StudentID=6,Name="Asif",Age=22},
            };

            //Method Syntax
            Student[] teens = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            //linq to fund first student whose name is Bhanu
            Student bhanu = studentArray.Where(s => s.Name == "Bhanu").FirstOrDefault();

            //linq to find the student whose student id is 5
            Student fifthstudent = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(bhanu.ToString() + "," + fifthstudent.ToString());

            //2. of type
            IList list1 = new ArrayList() { 0, "Abhi", 1, "two", 3, 'g' };
            ArrayList list = new ArrayList() { 0, "Abhi", 1, "two", 3, 'g' };
            var onlyString = list.OfType<string>();
            foreach (var v in onlyString)
            {
                Console.WriteLine(v);
            }

            //3.Order by and orderbydescending
            var sortedStudentlist = studentArray.OrderBy(s => s.Age);
            var sortedStudentListDescending = studentArray.OrderByDescending(s => s.Age);


            foreach (var v in sortedStudentlist)
            {
                Console.WriteLine(v.ToString());
            }
            var sortedStudentListThenName = studentArray.OrderBy(s => s.Age).ThenBy(s => s.Name);
            foreach (var v in sortedStudentListThenName)
            {

                Console.WriteLine("v");
            }

            //Groupby
            var groupedResult = studentArray.GroupBy(s => s.Age);
            foreach (var ageGroup in groupedResult)
            {

                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                    Console.WriteLine("Student Name:{0}", s.ToString());
            }
            //join
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
            IList<string> strList2 = new List<string>() { "One", "Two", "Five", "Six" };

            var innerJoin = strList1.Join(strList2,
                str1 => str1,
                str2 => str2,
                (str1, str2) => str1);
            foreach (string s in innerJoin)
            {
                Console.WriteLine(s);
            }

            //Groupjoin
            List<Class1> listClass1 = new List<Class1>()
            {
                new Class1(){ Id = 1 , Value="A"},
                new Class1(){ Id = 2 , Value="B"},
                new Class1(){ Id = 3 , Value="C"}
            };

            List<Class2> listClass2 = new List<Class2>()
            {
                   new Class1(){ Id = 1 , childValue="a1"},
                    new Class1(){ Id = 1 , childValue="a2"},
                     new Class1(){ Id = 1 , childValue="a3"},
                      new Class1(){ Id = 2 , childValue="b1"},
                       new Class1(){ Id = 2 , childValue="b2"},
            };
            var groupJoin = listClass1.GroupJoin(listClass2,
                lc1 => lc1.Id,
                lc2 => lc2.Id,
                (value, childValues) => { value = value,childValues = childValues});

            foreach(var v in groupJoin)
            {

                Console.WriteLine(item.Value.Value);
                foreach (var v in item.ChildValues)
                    Console.Write(v.ChildValue + ",");
                Console.WriteLine();


            }
            //Select& selectmany

            var selectresuly
            }
        }
    }
}