using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DAL;

namespace BAL
{
    public interface IBookDetails
    {
        int SaveBook(BusinessObjects.BookDetails objbook);
        int DeleteBook(BusinessObjects.BookDetails objbook);
        int UpdateBook(BusinessObjects.BookDetails objbook);
        DataSet GetBookDeatils();
    }
    public class BookDetails : IBookDetails
    {
        DAL.BookDetails objDAL = new DAL.BookDetails();
        public int SaveBook(BusinessObjects.BookDetails objbook)
        {
            int i = objDAL.SaveBookp(objbook);
            return i;
        }
        public int DeleteBook(BusinessObjects.BookDetails objbook)
        {
            int i = objDAL.DeleteBook(objbook);
            return i;
        }
        public int UpdateBook(BusinessObjects.BookDetails objbook)
        {
            int i = objDAL.UpdateBook(objbook);
            return i;
        }
        public DataSet GetBookDeatils()
        {
            DataSet ds = objDAL.GetBookdetails();
            return ds;
        }
    }
}
