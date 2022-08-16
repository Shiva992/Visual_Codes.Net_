using System;

namespace ProductManagement

{//presentationLayer
    class ProductManagementIO : IProductManagementIO
    {
        IBusinessLogicLayer businessLayer = new BusinessLogicLayer();
        public byte Menu()
        {
            Console.WriteLine("Press 1 if you want to Add Category \n");
            Console.WriteLine("Press 2 if you want to display Categories \n");
            Console.WriteLine("Press 3 if you want to Add Product \n");
            Console.WriteLine("Press 4 if you want to display Product \n");
            Console.WriteLine("Press 5 if you want to Update Product based on ProductID \n");
            Console.WriteLine("Press 6 if you want to Delete Product based on ProductID \n");           
            Console.WriteLine("Press 7 if you want to display Product based on ProductID \n");
            Console.WriteLine("Press 0 to Exit");
            Console.WriteLine("Enter option");
            byte option = Convert.ToByte(Console.ReadLine());
            return option;
        }
        public void AddProduct()
        {
            Console.WriteLine("Enter ProductId: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name :");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Price :");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter CategoryID :");
            int categoryId = Convert.ToInt32(Console.ReadLine());

            DBLayer dBLayer = new DBLayer();
            Product productDetails = new Product()
            {
                ProductID = productId,
                ProductName = productName,
                Price = price,
                CategoryID = categoryId
            };
            bool addRecord = dBLayer.AddProductDetails(productDetails);
            //Display(student);
            DisplayAll();
            Console.WriteLine("=========================================");

        }

       
        public void DisplayAll()
        {
            Console.WriteLine();
            businessLayer.DisplayAllProduct();
            Console.WriteLine();
        }


        public void DeleteProduct()
        {
            Console.WriteLine("Enter ProductID");
            int id = Convert.ToInt32(Console.ReadLine());
            if (businessLayer.DeleteProduct(id))
            {
                Console.WriteLine("Product deleted successfully");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        public void UpdateProduct()
        {
            Console.WriteLine("Enter ProductID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter New Price");
           int price = Convert.ToInt32(Console.ReadLine());
            businessLayer.UpdateProductPrice(id, price);

        }

        public void DisplayProductBasedOnProductID()
        {
            Console.WriteLine("Enter ProductID:");
            int id = Convert.ToInt32(Console.ReadLine());          
            businessLayer.DisplayProductBasedOnProductID(id);

        }
    }
}