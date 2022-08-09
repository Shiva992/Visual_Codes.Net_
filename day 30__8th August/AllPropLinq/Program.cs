using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1_Practice_LINQ
{
    class Class1
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
    class Class2
    {
        public int Id { get; set; }
        public string ChildValue { get; set; }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string namesWithA { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            string[] names = { "Abhi", "Wicked", "Harsh", "Aakash" };
            //LINQ QUERY
            var namesWithA = from name in names
                             where name.Contains('a')
                             select name;
            foreach (string s in namesWithA)
            {
                Console.Write(s + " ");

            }
            Console.WriteLine();
            Student[] studentArray =   {
                new Student(){StudentID=1, namesWithA="Abhi",Age=18},
                new Student(){StudentID=2, namesWithA="Harsh",Age=21},
                new Student(){StudentID=3, namesWithA="Aakash",Age=25},
                new Student(){StudentID=4, namesWithA="Devraj",Age=21},
                new Student(){StudentID=5, namesWithA="Bhanu",Age=27 },
                new Student(){StudentID=6, namesWithA="Ankit",Age=17 },
                new Student(){StudentID=7, namesWithA="Asif",Age=19},
                            //  new Student(){StudentID=1, namesWithA="Abhi",Age=18},

            };
            //method Syntax
            Student[] teens = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            //LINQ to find first student whose name is Bill
            Student bill = studentArray.Where(s => s.namesWithA == "Harsh").FirstOrDefault();

            //LINQ to find student whose Student ID is 5
            Student fifthStudent = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(bill.ToString() + ",  " + fifthStudent.ToString());


            //2.ofType
            IList list = new ArrayList() { 0, "Abhi", 1, "two", 3, 'g' };
            var onlyString = list.OfType<string>();
            foreach (var v in onlyString)
            {
                Console.WriteLine(v);
            }

            //3. Order & orderby Descending
            var sortedStudentList = studentArray.OrderBy(s => s.Age);
            var sortedStudentListDescending = studentArray.OrderByDescending(S => S.Age);
            foreach (var v in sortedStudentList)
            {
                Console.WriteLine(v.ToString());
            }
            //4. Then by & Then by descending
            var sortedStudentListThenName = studentArray.OrderBy(s => s.Age).ThenBy(s => s.Name);
            foreach (var v in sortedStudentListThenName)
            {
                Console.WriteLine(v);
            }

            //5. GroupBy &  toLook ---Deffered ______Immediate
            var groundResult = studentArray.GroupBy(s => s.Age);
            foreach (var ageGroup in groundResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                    Console.WriteLine("Student Name:{0}", s.ToString());
            }
            //6. Join
            IList<string> strList1 = new List<string>() { "one", "Two", "three", "Four" };
            IList<string> strList2 = new List<string>() { "one", "Two", "Five", "Six" };
            var innerJoin = strList1.Join(strList2,
                                    str1 => str1,
                                    str2 => str2,
                                    (str1, str2) => str1);
            foreach (string s in innerJoin)
            {
                Console.WriteLine(s);
            }

            //7. Group Join
            List<Class1> listClass1 = new List<Class1>()
            {
                new Class1(){Id=1,Value="A"},
                new Class1(){Id=2, Value="B"},
                new Class1(){Id=3,Value="C"}

            };
            List<Class2> listClass2 = new List<Class2>()
            {
                new Class2(){ Id=1,ChildValue="a1"},
                new Class2(){ Id=1,ChildValue="a2"},
                //new Class2(){ ID=,ChildValue="a1"},
                new Class2(){ Id=1,ChildValue="a3"},
                new Class2(){ Id=2,ChildValue="b1"},
                new Class2(){ Id=2,ChildValue="b2"},
            };
            var groupJoin = listClass1.GroupJoin(listClass2, lc1 => lc1.Id, lc2 => lc2.Id,
                (value, childvalues) => new { Value = value, childValues = childvalues });
            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.Value.Value);
                foreach (var v in item.childValues)
                    Console.Write(v.ChildValue + ",  ");
                Console.WriteLine();
            }

            //8. Select & Select Many

            var selectResult = studentArray.Select(s => new { StudentName = s.Name, Age = s.Age }).Where(s => s.Age > 19);
            foreach (var s in selectResult)
            {
                Console.WriteLine(s.StudentName);
                Console.WriteLine(s.Age);

            }
            var selectMany = studentArray.SelectMany(s => s.Name).ToList();
            foreach (var s in selectMany)
            {
                Console.WriteLine(s.ToString());
            }

            //9.  All any & Contains --- Quantifier operators

            bool areAllStudentsTeenager = studentArray.All(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(areAllStudentsTeenager);
            bool areAnyStudentsteenager = studentArray.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(areAnyStudentsteenager);

            Student std = new Student() { StudentID = 2, Name = "Harsh", Age = 21 };
            Console.WriteLine(studentArray.Contains(std));

            //10.  Elemment operators
            var st = studentArray.FirstOrDefault(s => s.Name.Contains("a"));
            Console.WriteLine(st.Name);
            var st2 = studentArray.LastOrDefault(s => s.Name.Contains("a"));
            Console.WriteLine(st2.Name);
        }
    }
}
