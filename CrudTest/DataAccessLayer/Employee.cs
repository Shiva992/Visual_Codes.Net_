using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BusinessObjects;

namespace DataAccessLayer
{
    public class Employee
    {
        public int SaveEmp(BusinessObjects.Employee objempbo)
        {    
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("addemp",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            cmd.Parameters.AddWithValue("@ename", objempbo.Ename);
            cmd.Parameters.AddWithValue("@salary", objempbo.Salary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteEmp(BusinessObjects.Employee objempbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("deleteemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateEmp(BusinessObjects.Employee objempbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("updateemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", objempbo.Eno);
            cmd.Parameters.AddWithValue("@ename", objempbo.Ename);
            cmd.Parameters.AddWithValue("@salary", objempbo.Salary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataSet GetEmps()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("getemp", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            return ds;
        }
    }
}
