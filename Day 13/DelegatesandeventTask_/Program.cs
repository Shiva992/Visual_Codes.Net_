using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnDelegatesAndEvents
{

    public delegate void userDelegate(string str);

    class Program
    {

        static void userName(string s)
        {
            Console.WriteLine("Welcome " + s);
        }

        static void Banned(string s)
        {
            Console.WriteLine("You are not allowed");
        }

        static void Main(string[] args)
        {
            User a = new User();
            a.userEvent += new userDelegate(userName);
            a.banEvent += new userDelegate(Banned);
            Console.WriteLine("Enter Name");
            string input = Console.ReadLine();
            a.Add(input);
            Console.ReadLine();
        }
    }

    class User
    {
        public event userDelegate userEvent;
        public event userDelegate banEvent;

        public void Add(string s)
        {
            switch (s)
            {
                case "Ram":
                    banEvent(s);
                    break;

                case "Sham":
                    banEvent(s);
                    break;

                case "Naveen":
                    banEvent(s);
                    break;

                default:
                    userEvent(s);
                    break;
            }
        }
    }
}