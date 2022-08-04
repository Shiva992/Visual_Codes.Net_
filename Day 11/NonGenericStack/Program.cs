using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 
            Stack stack = new Stack();

            //Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");

            //Displaying
            foreach (var st in stack)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(stack.Peek());

            //REmoving
            Console.WriteLine("Sequence pf removing");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}