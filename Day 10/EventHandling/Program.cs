using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo
{
    // This is Subscriber Class
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(AlertMessage);
            a.Add();
            Console.Read();
        }

        static void EventMessage()
        {
            Console.WriteLine("Event Executed : This is Odd Number");
        }
        static void AlertMessage()
        {
            Console.WriteLine("Event Executed : Event Executed");
        }
    }

    // This is Publisher Class
    class
}