using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MulticastDelegates
    {
        public delegate void MyDelegate(int a, int b);
        static void Main(string[]args)
        {
            MyDelegate m = Add;
            m = m + Multiply;
            m = m + Subtract;
            m(200, 50);
            Console.WriteLine("--------------------");
            m = m - Multiply;
            m.Invoke(300, 100);
            Console.ReadKey();
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition= " + (x + y));
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication=" + (x * y));
        }
        public static void Subtract(int x, int y)
        {
            Console.WriteLine("Subtraction=" + (x - y));
        }
    }
}
