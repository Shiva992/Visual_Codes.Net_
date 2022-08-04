using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class Example
    {
        int a;
        int b;
        public Example()
        {
        }
        public Example(int x, int y)
        {
            a = x;
            b = y;
        }
        public void Display()
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
    class Program
    {
        public static void Main()
        {
            Example e1 = new Example(40, 20);
            e1.Display();
            Example e2 = new Example(40, 20);
            e2.Display();
            Example e3 = e2;
            e3.Display();
            if (e1.Equals(e2))
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");
            if (e2.Equals(e3))
                Console.WriteLine("equal");
            else
                Console.WriteLine("not equal");
            Console.ReadLine();
        }
    }
}