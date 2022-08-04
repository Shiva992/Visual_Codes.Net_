using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stk = new Stack<string>();

            stk.Push("Iphone");
            stk.Push("Samsung");
            stk.Push("Oneplus");
            stk.Push("Xiaomi");
            stk.Push("Vivo");

            //Count
            Console.WriteLine("Count of the stack: {0}", stk.Count);

            //Display
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================");
            Console.WriteLine(stk.Peek());

            //Contains
            Console.WriteLine("===================");
            Console.WriteLine("stk.Contains(\"Oppo\") = {0}", stk.Contains("Oppo"));



            Console.ReadLine();
        }
    }
}