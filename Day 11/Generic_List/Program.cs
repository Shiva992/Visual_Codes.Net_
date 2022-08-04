using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and initialising 
            List<string> firstList = new List<string>
            {
                "Australia", "Belgium", "Brazil"
            };

            firstList.Add("Russia");
            List<string> secondList = new List<String>();

            //Adding
            firstList.Add("India");
            firstList.Add("England");
            firstList.Add("Egypt");
            firstList.Add("Hungary");
            firstList.Add("Germany");
            firstList.Add("China");

            //Displaying
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            //Index
            Console.WriteLine("==================================");
            firstList[3] = "South Korea";
            Console.WriteLine(firstList[3]);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            //Capacity

            Console.WriteLine("Count : " + firstList.Count);

            //Sorting

            Console.WriteLine("After Sorting : ");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            //Reversing
            Console.WriteLine("After REversing:  ");
            firstList.Reverse();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }

            //Removing
            Console.WriteLine("================================");
            Console.WriteLine("AFter REmoving ...");
            firstList.Remove("Germany");
            firstList.RemoveAt(0);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count now is " + firstList.Count);
            //RemoveAll
            //firstList.Clear();
            //Contains

            Console.WriteLine("==========================");
            Console.WriteLine(firstList.Contains("Egypt"));

            //GetRange

            secondList = firstList.GetRange(0, 3);
            Console.WriteLine("Now we are in the second list");
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}