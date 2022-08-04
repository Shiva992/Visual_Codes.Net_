using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    public static class StringExtension
    {
        public static int GetWordCount(this string inputstring)
        {
            if (!string.IsNullOrEmpty(inputstring))
            {
                string[] strArray = inputstring.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }

        public static int Addition(int a, int b)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string myword = "Welcome to Elearning tutors by GLobal Logic TRainings";
            int wordCount = myword.GetWordCount();

            //StringExtension.GetWordCount(myword);
            Console.WriteLine("string : " + myword);
            Console.WriteLine("Count : " + wordCount);
            Console.ReadLine();
        }
    }
}