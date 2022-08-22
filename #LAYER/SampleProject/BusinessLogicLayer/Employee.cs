using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Employee
    {
        readonly DataAccessLayer.Employee objdalemp = new DataAccessLayer.Employee();
        public int AddEmployee(BusinessObjects.Employee objboemp)
        {
           int i = objdalemp.AddEmployee(objboemp);
            return i;
        }
        public int DeleteEmployee(BusinessObjects.Employee objboemp)
        {
            int i = objdalemp.DeleteEmployee(objboemp);
            return i;
        }
        public int UpdateEmployee(BusinessObjects.Employee objboemp)
        {
            int i = objdalemp.UpdateEmployee(objboemp);
            return i;
        }
        public DataSet GetEmp()
        {
            DataSet ds = objdalemp.GetEmployee();
            return ds;

        }
    }
}
