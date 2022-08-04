using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabletypes

{
    class Myclass
    {
        public Nullable<int> i;
    }
    class Program
    {

        static void Main(string[] args)
        {
            //In C3, if we try to assign a null value to the value type variables,
            //then we will get a compile time error.

            //try this

            //int? g = null /// its the right way for assigning the nullable type
            //int g =null /// this will give error.
            //bool y  =true;
            // console.writeline("")
            Myclass cls = new Myclass();
            if (cls.i == null)
            {
                Console.WriteLine("Null");

            }
            else
            {
                Console.WriteLine(cls.i.Value);

            }
            //=============================================

            int? a = null;
            if (a.HasValue)
            {
                Console.WriteLine("x = {0}", a.Value);

            }
            else
            {
                Console.WriteLine("Value is Empty");
            }
            Console.ReadLine();

            int? x = null;
            Nullable<int> z;
            int y = x ?? 0;
            Console.WriteLine("y = {0}", y);
            Console.ReadLine();
        }
    }
}