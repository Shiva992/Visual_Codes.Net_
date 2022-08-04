using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program

    {
        detail
        private int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            detail("pqr");
            detail("ABCD", 14);
            //Calling the detail method
            detail("XYZ\n", 123);
            detail("ABC\n", 456, "A-");
            detail("DEF\n", 789, "B+", "Software Developer");

            //Named Parameters
            Program ps = new Program();
            int result = ps.Add(y: 50, x: 20, z: 12);
            Console.WriteLine("Instance Method Output" + result);
            Console.ReadLine();
        }
    }
}