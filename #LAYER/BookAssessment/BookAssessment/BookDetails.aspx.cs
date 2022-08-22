using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BusinessObjects;

namespace BookAssessment
{
    public partial class BookDetails : System.Web.UI.Page
    {
        BAL.BookDetails objBLL = new BAL.BookDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
                FillData();
        }
        private void FillData()
        {
            try
            {
                DataSet ds = objBLL.GetBookDeatils();
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessObjects.BookDetails objbook = new BusinessObjects.BookDetails();
                objbook.BookName = txtbookName.Text;
                objbook.Aurthor = txtAurthor.Text;
                objbook.Publisher = txtPublisher.Text;
                objbook.Price = decimal.Parse(txtprice.Text);
                if (objbook.Price < 0)
                {
                    Response.Write("Price must be greater than 0");
                }
                else
                {
                    int i = objBLL.SaveBook(objbook);
                    if (i == 1)
                    {
                        Response.Write("Saved!!!");
                        FillData();
                    }
                    else
                        Response.Write("Failed!!!");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                BusinessObjects.BookDetails objBook = new BusinessObjects.BookDetails();
                GridViewRow row = GridView1.Rows[e.RowIndex];
                Label l1 = (Label)row.FindControl("Label1");
                objBook.BookId = int.Parse(l1.Text);
                int i = objBLL.DeleteBook(objBook);
                if (i == 1)
                    FillData();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView1.Rows[e.RowIndex];
                TextBox t1 = (TextBox)row.FindControl("TextBox1");
                TextBox t2 = (TextBox)row.FindControl("TextBox2");
                TextBox t3 = (TextBox)row.FindControl("TextBox3");
                TextBox t4 = (TextBox)row.FindControl("TextBox4");
                TextBox t5 = (TextBox)row.FindControl("TextBox5");
                BusinessObjects.BookDetails objbook = new BusinessObjects.BookDetails();
                objbook.BookId = int.Parse(t1.Text);
                objbook.BookName = t2.Text;
                objbook.Aurthor = t3.Text;
                objbook.Publisher = t3.Text;
                objbook.Price = decimal.Parse(t5.Text);
                int i = objBLL.UpdateBook(objbook);
                if (i == 1)
                {
                    GridView1.EditIndex = -1;
                    FillData();

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            try
            {
                GridView1.EditIndex = -1;
                FillData();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}