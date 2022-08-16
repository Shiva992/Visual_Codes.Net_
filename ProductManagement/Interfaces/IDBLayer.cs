namespace ProductManagement
{
    public interface IDBLayer
    {
        bool AddProductDetails(Product productDetails);
        bool AddCategoryDetails(Category categoryDetails);
        bool DeleteProductDetails(int productId);
        bool UpdateProductDetails(int id, int price);
        bool DisplayProductDetails();
        bool DisplayCategoryDetails();
        bool DisplayProductDetailsBasedOnID(int id);
    }
}