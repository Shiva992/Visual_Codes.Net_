using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            Queue queue = new Queue();
            //Adding
            queue.Enqueue("Rishabh");
            queue.Enqueue("Chirag");
            queue.Enqueue("Amit");
            Console.WriteLine("Count: {0} ", queue.Count);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Contains
            Console.WriteLine("checking for Amit: " + queue.Contains("Amit"));


            //Peek
            Console.WriteLine("Peek :" + queue.Peek());
            //Removing
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.ReadKey();
        }
    }
}