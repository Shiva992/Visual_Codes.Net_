using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedDemo
{
    sealed class ClassDemo
    {
        public void Add()
        {
            Console.WriteLine("I am from sealed class");
        }
    }
    //Sealed class cannot be inherited by other derived classes 
    // in this example classDemo is base class and it is sealed 
    // and class B is derived class so it cannot inherit the base class ClassDemo
    class B
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassDemo obj = new ClassDemo();
            obj.Add();
            Console.ReadKey();
        }
    }
}