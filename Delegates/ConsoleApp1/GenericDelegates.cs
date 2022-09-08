using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericDelegates
    {
        public delegate T MyGenericDelegate<T>(T a, T b);
        static void Main(string[] args)
        {
            MyGenericDelegate<int> dAdd = Add;
            Console.WriteLine(dAdd(10, 20));

            MyGenericDelegate<string> dstring = AddString;
            Console.WriteLine(dstring("Hi" , "Generic Delegates"));
            Console.ReadKey();
        }
            public static int Add(int a , int b)
        {
            return a + b;
        }
        public static string AddString(string s1 , string s2)
        {
            return s1 + s2;
        }
        }
    }

