using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int MyDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            MyDelegate md1 = Addition;
            MyDelegate md2 = new MyDelegate(Addition);

            MyDelegate md3 = (int a, int b) => a + b;
            int result = md1.Invoke(100, 40);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        public static int Addition (int n1 , int n2)
        {
            return n1 + n2;
        }
    }
}
