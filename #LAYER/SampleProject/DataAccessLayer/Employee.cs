using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BusinessObjects;
namespace DataAccessLayer
   
{
   public  class Employee
    {
        public int AddEmployee(BusinessObjects.Employee objboemp)
        {
            SqlConnection  con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_addemp",con);//procedure name
            cmd.CommandType = CommandType.StoredProcedure;//storedProcedure
            cmd.Parameters.AddWithValue("@eno",objboemp.Eno);
            cmd.Parameters.AddWithValue("@ename",objboemp.Ename);
            cmd.Parameters.AddWithValue("@salary",objboemp.Salary);
            cmd.Parameters.AddWithValue("@dname",objboemp.Dname);
            cmd.Parameters.AddWithValue("@gender",objboemp.Gender);
            cmd.Parameters.AddWithValue("@location",objboemp.Location);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public DataSet GetEmployee()
        {
            throw new NotImplementedException();
        }

        public int DeleteEmployee(BusinessObjects.Employee objboemp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_deleteemp", con);//procedure name
            cmd.CommandType = CommandType.StoredProcedure;//storedProcedure
            cmd.Parameters.AddWithValue("@eno",objboemp.Eno);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public int UpdateEmployee(BusinessObjects.Employee objboemp)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_updateemp", con);//procedure name
            cmd.CommandType = CommandType.StoredProcedure;//storedProcedure
            cmd.Parameters.AddWithValue("@eno",objboemp.Eno);
            cmd.Parameters.AddWithValue("@ename",objboemp.Ename);
            cmd.Parameters.AddWithValue("@salary",objboemp.Salary);
            cmd.Parameters.AddWithValue("@dname",objboemp.Dname);
            cmd.Parameters.AddWithValue("@gender",objboemp.Gender);
            cmd.Parameters.AddWithValue("@location",objboemp.Location);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public DataSet GetEmp()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("proc_getemp", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            return ds;
        }
    }
}
