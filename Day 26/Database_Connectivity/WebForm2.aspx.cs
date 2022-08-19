using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Database_Connectivity
{
    public partial class WebForm2 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into UserData values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();

            int result = cmd.ExecuteNonQuery();

            con.Close();




            if (result >= 1)
            {
                Response.Write("Data saved successfully");
            }

            else
            {
                Response.Write("something went wrong ! data not saved");
            }
        }
             

    }

}

