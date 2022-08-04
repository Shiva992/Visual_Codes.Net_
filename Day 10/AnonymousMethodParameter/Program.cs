using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodParameter
{
    public delegate void Print(int value);
    class Program
    {
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }
        static void Main(string[] args)
        {
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Anonymous method: {0}", val);
            }, 100);
        }
    }
}