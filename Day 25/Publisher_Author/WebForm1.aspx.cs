using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Publisher_Author
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                con.Open();
                string insert = "insert into USERINFORMATION (username , roll number) values(@username, @roll number)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@userbname",TextBox3.Text);
                cmd.Parameters.AddWithValue("@userbname", TextBox4.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("home.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}