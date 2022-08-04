using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class MyException : ApplicationException
    {
        public void MyException()
        {
            Console.WriteLine("An Exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    var num = int.Parse(Console.ReadLine());
            //    int result = 100 / num;
            //    Console.WriteLine("{100}/ {0} = {1}", num, result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.ReadLine();
            //}
            //catch(InvalidCastExce)

            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();

                }
            }
            catch (MyException e)
            {
                e.MyDivideException();
            }

            res = d / div;
            Console.WriteLine("REsult : {0}", res);
        }
    }
}