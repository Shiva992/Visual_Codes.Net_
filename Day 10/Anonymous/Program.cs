using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void operation();
        static void Main(string[] args)
        {
            operation obj = delegate
            {
                Console.WriteLine(" I am Anonymous method");
            };
            obj();
            Console.ReadLine();
        }
    }
}