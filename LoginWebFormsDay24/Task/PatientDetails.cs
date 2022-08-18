using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_August_task
{
    public class PatientDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Disease { get; set; }
        public string Doctor_In_Charge { get; set; }
        public string Room_No { get; set; }
    }
}