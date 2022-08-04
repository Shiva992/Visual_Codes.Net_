using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class User
    {
        public readonly string name = "rishabh";
        public readonly string location;
        public readonly int age;
        public User()
        {
            location = "Bangalore";
            age = 23;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            //this will throw compile time error
            //u.name = "rohini iyengar";
            Console.WriteLine("Name: {0}", u.name);
            Console.WriteLine("Location: {0}", u.location);
            Console.WriteLine("Age: {0}", u.age);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();

        }
    }
}