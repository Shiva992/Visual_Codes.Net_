using System;

namespace ProductManagement
//presentationlayer -->businesslogiclayer

{
    public class CategoryManagementIO : ICategoryManagementIO
    {

        public void AddCategory()
        {
            Console.WriteLine("Enter CategoryID: ");

            int categoryId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter CategoryName :");

            string categoryName = Console.ReadLine();


            DBLayer dBLayer = new DBLayer();
            Category categoryDetails = new Category()
            {
                CategoryID = categoryId,
                CategoryName = categoryName
            };
            bool addRecord = dBLayer.AddCategoryDetails(categoryDetails);

            DisplayAll();

            Console.WriteLine("=========================================");

        }
        public void DisplayAll()
        {
            IBusinessLogicLayer businessLayer = new BusinessLogicLayer();
            Console.WriteLine();
            businessLayer.DisplayAllCategory();
            Console.WriteLine();
        }
    }
}
