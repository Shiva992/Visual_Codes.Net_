using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public interface IBusinessLogicLayer
    {
        bool UpdateProductPrice(int id, int price);
        void DisplayAllProduct();
        void DisplayAllCategory();
        void DisplayProductBasedOnProductID(int id);
        bool DeleteProduct(int id);
    }
}