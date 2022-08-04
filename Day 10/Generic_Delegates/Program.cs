using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        public static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }
        public static int Multi(int a, int b)
        {
            return a * b;
        }
        public static void sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void add(string fname, string lname)
        {
            string fullname = fname + " " + lname;
            Console.WriteLine(fullname);
        }
        static void Main(string[] args)
        {
            Action<int, int> a = new Action<int, int>(Program.sum);
            a(15, 10);

            Action<string, string> b = new Action<string, string>(Program.add);
            b("chirag", "bedi");

            Func<int, int, int> fs = new Func<int, int, int>(Program.Multi);
            Console.WriteLine(fs(10, 23));

            Predicate<string> date = new Predicate<string>(Program.IsDate);
            if (date("10-26-2022"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}