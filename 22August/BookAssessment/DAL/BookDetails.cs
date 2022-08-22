using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DAL
{
    public class BookDetails
    {
        public int SaveBookp(BusinessObjects.BookDetails objbook)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("addbook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bname", objbook.BookName);
            cmd.Parameters.AddWithValue("@aurthor", objbook.Aurthor);
            cmd.Parameters.AddWithValue("@publisher", objbook.Publisher);
            cmd.Parameters.AddWithValue("@price", objbook.Price);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int DeleteBook(BusinessObjects.BookDetails objbook)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("deletebook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Bookid", objbook.BookId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int UpdateBook(BusinessObjects.BookDetails objbook)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("updatebook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Bookid", objbook.BookId);
            cmd.Parameters.AddWithValue("@bookname", objbook.BookName);
            cmd.Parameters.AddWithValue("@aurthor", objbook.Aurthor);
            cmd.Parameters.AddWithValue("@publisher", objbook.Publisher);
            cmd.Parameters.AddWithValue("@price", objbook.Price);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataSet GetBookdetails()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("getbook", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "bookdetails");
            return ds;
        }
    }
}
