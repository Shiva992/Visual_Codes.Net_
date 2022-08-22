using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{

    public interface Employees
    {
        int SaveEmp(BusinessObjects.Employee objempbo);
        int DeleteEmp(BusinessObjects.Employee objempbo);
        int UpdateEmp(BusinessObjects.Employee objempbo); //interfaces
        DataSet GetEmps();
    }
    public class Employee : Employees
    {
        DataAccessLayer.Employee objempdal = new DataAccessLayer.Employee();
        public int SaveEmp(BusinessObjects.Employee objempbo)
        {
            int i = objempdal.SaveEmp(objempbo);
            return i;
        }
        public int DeleteEmp(BusinessObjects.Employee objempbo)
        {
            int i = objempdal.DeleteEmp(objempbo);
            return i;
        }
        public int UpdateEmp(BusinessObjects.Employee objempbo)
        {
            int i = objempdal.UpdateEmp(objempbo);
            return i;
        }
        public DataSet GetEmps()
        {
            DataSet ds = objempdal.GetEmps();
            return ds;
        }
    }
}
