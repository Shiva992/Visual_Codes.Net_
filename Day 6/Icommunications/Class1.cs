using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_concept
{

    interface IACT
    {
        void network();
    }
    class ABC : IWork, IACT, ICommunications
    {
        public void add()
        {
            Console.WriteLine("I am from IWork Interface");
        }

        public int calc()
        {
            int result = 55;
            return result;
        }
        public void CNN()
        {
            throw new NotImplementedException();
        }

        public void network()
        {
            Console.WriteLine("I am from IACT network");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ABC obj = new ABC();
            obj.add();
            obj.calc();
            obj.network();
            XYZ objx = new XYZ();
            objx.calc();
            objx.add();

        }
    }
}