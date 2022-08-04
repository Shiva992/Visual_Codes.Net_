using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_program
{
    static class Program
    {
        public static int InstaCalculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        public static string Name;
        public static string FirstName;

        static Program()
        {
            Name = "Global Logic TRaining";
        }

        public static int calculation(int x, int y)
        {
            int val = x * y;
            return val;
        }
        static void Main(string[] args)
        {
            //Program x = new Program();
            // int newval = x.InstaCalculation(12, 12);
            Console.WriteLine(InstaCalculation(12, 12));
            calculation(4, 4);
            Console.WriteLine(calculation(12, 12));
            Console.WriteLine(Name);
        }
    }
}