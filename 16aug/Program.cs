using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductManagementIO productManagementIO = new ProductManagementIO();
           ICategoryManagementIO categoryManagementIO = new CategoryManagementIO();
            Boolean toExit = true;
            do
            {
                switch (productManagementIO.Menu())
                {
                    case 1:
                        {
                            categoryManagementIO.AddCategory();
                            break;
                        }
                    case 2:
                        {
                            categoryManagementIO.DisplayAll();
                            break;
                        }
                    case 3:
                        {
                            productManagementIO.AddProduct();
                            break;
                        }
                    case 4:
                        {
                            productManagementIO.DisplayAll();
                            break;
                        }
                    case 5:
                        {
                            productManagementIO.UpdateProduct();
                            break;
                        }
                    case 6:
                        {
                            productManagementIO.DeleteProduct();
                            break;
                        }
                    case 7:
                        {
                            productManagementIO.DisplayProductBasedOnProductID();
                            break;
                        }

                    case 0:
                        {
                            toExit = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter the valid option");
                            break;
                        }
                }
                //studentManagementIO.Menu();
            } while (toExit);
        }
    }
}