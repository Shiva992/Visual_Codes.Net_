using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DelegateParameter
    {
        public delegate void MyDelegate(string str);
        static void Main(string[]args)
        {
            MyDelegate m = print;
            InvokeMyDelegate(m);
            Console.ReadKey();
        }
        public static void InvokeMyDelegate(MyDelegate md)
        {
            md("This is delegate which is passed as a method parameter");
        }
        public static void print(string s)
        {
            Console.WriteLine(s);
        }

    }
}
