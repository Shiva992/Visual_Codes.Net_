using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;
using System.Data;

namespace PresentationLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objbllemp = new BusinessLogicLayer.Employee();
        BusinessObjects.Employee objboemp = new BusinessObjects.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            objboemp.Eno = int.Parse(TextBox1.Text);
            objboemp.Ename = TextBox2.Text;
            objboemp.Salary = double.Parse(TextBox3.Text);
            objboemp.Dname = DropDownList1.SelectedItem.ToString();
            objboemp.Gender = "";
            if(RadioButton1.Checked==true)
            {
                objboemp.Gender = RadioButton1.Text;
            }
            else if (RadioButton2.Checked==true)
            {
                objboemp.Gender = RadioButton2.Text;
            }
            objboemp.Location = "";
            if(CheckBox1.Checked==true)
            {
                objboemp.Location = CheckBox1.Text + ",";
            }
            if (CheckBox2.Checked == true)
            {
                objboemp.Location = objboemp.Location+CheckBox2.Text + ",";
            }
            if (CheckBox3.Checked == true)
            {
                objboemp.Location = objboemp.Location + CheckBox3.Text + ",";
            }
            int i = objbllemp.AddEmployee(objboemp);
            if (i ==1)
            {
                DataSet ds = objbllemp.GetEmp();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                   
            }

        }
    }
}