using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            //Adding
            capitals.Add("India", "Delhi");
            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "BErlin");
            //Displaying
            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);
            }
            foreach (KeyValuePair<string, string> item in capitals)
            {

            }

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Value);
            }
            //Creating with Initialization
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1, "James"},
                {2, "JAck" },
                {3, "Emma" }
            };

            foreach (var item in names)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            //oindex

            Console.WriteLine("===========================");
            capitals["Italy"] = "Venice";
            capitals["Brazil"] = "Rio di genero";
            Console.WriteLine(capitals["Italy"]);
            Console.WriteLine(capitals["Brazil"]);


            //Capacity

            //Try get value
            capitals.TryGetValue("Russia", out string result);
            if (result != null)
                Console.WriteLine("Result is " + result);

            //Remove
            capitals.Remove("Italy");
            Console.WriteLine("--------------------------");
            Console.WriteLine("After removing");
            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(capitals.Count);
            //rEmove all
            //Capitals.clear();

            //Contains
            Console.WriteLine(capitals.ContainsKey("France"));
            Console.ReadKey();
        }
    }
}