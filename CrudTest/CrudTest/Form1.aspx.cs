using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using BusinessObjects;
using System.Data;

namespace CrudTest
{          //class & objects 
    public partial class Form1 : System.Web.UI.Page
    {
        BusinessLogicLayer.Employee objempbll = new BusinessLogicLayer.Employee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                FillData();
            }
        }
        private void FillData()
        {
            DataSet ds = objempbll.GetEmps();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.Employee objEmpbo = new BusinessObjects.Employee();
                objEmpbo.Eno = int.Parse(txtempno.Text);
                objEmpbo.Ename = txtempname.Text;
                objEmpbo.Salary = double.Parse(txtempsal.Text);      //exception
                if (objEmpbo.Salary < 0 && objEmpbo.Eno < 0)
                {
                    Response.Write("Can't take -ve Value !!\n\n");
                }
                else
                {
                    int i = objempbll.SaveEmp(objEmpbo);
                    if (i == 1)
                    {
                        FillData();
                    }
                    else
                        Response.Write("Failed!!!");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Something went wrong!!" + ex.Message);
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                BusinessObjects.Employee objempbo = new BusinessObjects.Employee();
                GridViewRow row = GridView1.Rows[e.RowIndex];
                Label l1 = (Label)row.FindControl("Label1");
                objempbo.Eno = int.Parse(l1.Text);
                int i = objempbll.DeleteEmp(objempbo);
                if (i == 1)
                {
                    FillData();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Something went wrong !!" + ex.Message);
            }
        }

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            TextBox t1 = (TextBox)row.FindControl("TextBox1");
            TextBox t2 = (TextBox)row.FindControl("TextBox2");
            TextBox t3 = (TextBox)row.FindControl("TextBox3");
            BusinessObjects.Employee objempbo = new BusinessObjects.Employee();
            objempbo.Eno = int.Parse(t1.Text);
            objempbo.Ename = t2.Text;
            objempbo.Salary = double.Parse(t3.Text);
            int i = objempbll.UpdateEmp(objempbo);
            if (i == 1)
            {
                GridView1.EditIndex = -1;
                FillData();

            }

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillData();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}