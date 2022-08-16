using System;

namespace ProductManagement
{//call --> Db layer 
  
    class BusinessLogicLayer : IBusinessLogicLayer
    {
        public readonly IDBLayer dBLayer = new DBLayer();
        public bool UpdateProductPrice(int id, int price)
        {
            //DBLayer dBLayer = new DBLayer();
            bool isUpdated= dBLayer.UpdateProductDetails(id, price);
            return isUpdated;          
        }

        public void DisplayAllProduct()
        {

            Console.WriteLine("All Products are shown below:");
            //DBLayer dbLayer = new DBLayer();
            dBLayer.DisplayProductDetails();
        }

        public void DisplayAllCategory()
        {

            Console.WriteLine("All Categories are shown below:");
            //DBLayer dbLayer = new DBLayer();
            dBLayer.DisplayCategoryDetails();
        }

        public void DisplayProductBasedOnProductID(int id)
        {

            Console.WriteLine("Product is shown below:");
            //DBLayer dbLayer = new DBLayer();
            dBLayer.DisplayProductDetailsBasedOnID(id);
        }


        public bool DeleteProduct(int id)
        {
            //DBLayer dBLayer = new DBLayer();
            bool deleteRow = dBLayer.DeleteProductDetails(id);
            return deleteRow;
        }
    }
}
