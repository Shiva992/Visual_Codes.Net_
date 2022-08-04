using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            //Adding
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Mercedes", "Germany");
            hash.Add(1, "Germany");
            //Displaying
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);

            }
            //Capacity
            Console.WriteLine("Count is  " + hash.Count);

            //Remove
            Console.WriteLine("-----------------");
            Console.WriteLine("After Removing");
            hash.Remove("IKEA");

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            //Contains

            Console.WriteLine("--------------------");
            Console.WriteLine("Contains Condition");

            if (hash.ContainsValue("Germany"))
            {
                Console.WriteLine("Yes it is there");

            }
            else
            {
                Console.WriteLine("No it is not");
            }
            if (hash.ContainsValue("Sweden"))
            {
                Console.WriteLine("Yes it is there");
            }
            else
            {
                Console.WriteLine("No it is not");
            }

            //Copy to ArrayList
            Console.WriteLine("----------------------");
            Console.WriteLine("After copying");
            ArrayList array = new ArrayList(hash.Values);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}