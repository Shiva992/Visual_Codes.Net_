using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 
            //SortedList List = new SortedList(); // non generic sorted list
            SortedList<string, string> subjectTeacher = new SortedList<string, string>();

            //Adding
            subjectTeacher.Add("Arihant", "Maths");
            subjectTeacher.Add("Amit", "Science");
            subjectTeacher.Add("Rishabh", "English");
            subjectTeacher.Add("Chirag", "Computer Sci");


            //Display
            foreach (var item in subjectTeacher)
            {
                Console.WriteLine(item.Key + ", the subject taught by this teacher is " + item.Value);
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("Index : ");

            //Index
            subjectTeacher["Amit"] = "Hindi";
            Console.WriteLine("Checking the value for Amit " + subjectTeacher["Amit"]);

            //Remove
            Console.WriteLine("=============================");
            Console.WriteLine("After Removing");
            subjectTeacher.Remove("Chirag");

            //Count
            Console.WriteLine("Count is: " + subjectTeacher.Count);


            Console.WriteLine("=======================");
            //Contains
            Console.WriteLine("Checking the value for subject Maths " + subjectTeacher.ContainsValue("Maths"));
            Console.ReadKey();

        }
    }
}