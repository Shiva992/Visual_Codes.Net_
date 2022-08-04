using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_concept
{
    class XYZ : IWork
    {

        public void add()
        {
            Console.WriteLine("I am From class XYZ");
        }

        public int calc()
        {
            int sum;
            sum = 10;
            return sum;
        }
    }
}
