using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public interface IProductManagementIO
    {
        byte Menu();
        void AddProduct();
        void DisplayAll();
        void DeleteProduct();
        void UpdateProduct();
        void DisplayProductBasedOnProductID();
    }
}