using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_August_task
{
    class Program
    {
        public static void Main(string[] args)
        {
            BusinessLayer busLayer = new BusinessLayer();
            busLayer.HandlePatientRecords();
        }

    }
}