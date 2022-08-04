using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            ArrayList array = new ArrayList();

            //Adding
            array.Add("James");
            array.Add("David");
            array.Add("Charles");
            array.Add("Ahmad");
            array.Add(1);
            Console.WriteLine("At first");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Before insertion");
            Console.WriteLine("Count is " + array.Count);
            array.Insert(2, "Tim");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Insertion");
            Console.WriteLine("Count is " + array.Count);
            Console.ReadLine();
            //Index
            Console.WriteLine("-------------");
            Console.WriteLine(array[2].ToString());
            //Capacity
            Console.WriteLine("-------------");
            Console.WriteLine("Count is " + array.Count);
            //Sorting
            Console.WriteLine("-------------");
            array.Sort();
            Console.WriteLine("After sorting");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //Reversing
            Console.WriteLine("-------------");
            array.Reverse();
            Console.WriteLine("After reversing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //Removing
            Console.WriteLine("-------------");
            Console.WriteLine("After Removing");
            array.Remove("James");
            array.RemoveAt(2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            /////Remove all
            //array.Clear();
            Console.WriteLine("-------------");
            Console.WriteLine("After Removing some");
            array.RemoveRange(1, 2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //Contains
            Console.WriteLine("-------------");
            Console.WriteLine("After Asking if Contains");
            Console.WriteLine(array.Contains("James"));
            //Get Range
            ArrayList names = new ArrayList();
            names = array.GetRange(0, 3);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}