using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_parameters
{
    public class Author
    {
        //define a dynamic field 
        dynamic name;
        //define a dynamic property
        dynamic Nameproperty { get; set; }
        //define a dynamic method with a dynamic parameter type.
        public dynamic FullNameMethod(dynamic d)
        {
            name = "Mahesh";
            dynamic firstname = name;
            return firstname + " " + d;
        }
    }
    class Program
    {
        public static void mulval(dynamic val)
        {
            val *= val;
            Console.WriteLine(val);
            Console.ReadLine();
        }

        static void MyDynamicMethod(dynamic dynamicparam)
        {
            dynamic lastName = "Kumar";
            dynamic dynAuthor = new Author();
            Console.WriteLine(dynAuthor.FullNameMethod(lastName));
        }

        static void Main(string[] args)
        {
            //mulval(30);
            MyDynamicMethod("dynamic Vakue");
        }
    }
}