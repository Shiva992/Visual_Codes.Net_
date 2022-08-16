using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace ProductManagement

{
    public class DBLayer : IDBLayer
    {

        public bool AddProductDetails(Product productDetails)
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Product (ProductID, ProductName, Price, CategoryID) VALUES (@ProductID, @ProductName, @Price, @CategoryID)", connection);
                    insertCommand.Parameters.Add(new SqlParameter("ProductID", productDetails.ProductID));
                    insertCommand.Parameters.Add(new SqlParameter("ProductName", productDetails.ProductName));
                    insertCommand.Parameters.Add(new SqlParameter("Price", productDetails.Price));
                    insertCommand.Parameters.Add(new SqlParameter("CategoryID", productDetails.CategoryID));

                    Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    //Console.Clear();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AddCategoryDetails(Category categoryDetails)
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open(); //query //write-->sqlcommand
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Category (CategoryID, CategoryName) VALUES (@CategoryID, @CategoryName)", connection);
                    insertCommand.Parameters.Add(new SqlParameter("CategoryID", categoryDetails.CategoryID));
                    insertCommand.Parameters.Add(new SqlParameter("CategoryName", categoryDetails.CategoryName));//form

                    Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());//call
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    //Console.Clear();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteProductDetails(int productId)
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";


                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand deleteCommand = new SqlCommand("Delete from Product where ProductID=@ProductID", connection);//replace

                    deleteCommand.Parameters.Add(new SqlParameter("ProductID", productId));

                    Console.WriteLine("Commands executed! Total rows affected are " + deleteCommand.ExecuteNonQuery());
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateProductDetails(int id, int price)
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";


                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand updateCommand = new SqlCommand("Update Product set Price=@Price where ProductID=@ProductID", connection);
                    updateCommand.Parameters.Add(new SqlParameter("Price", price));
                    updateCommand.Parameters.Add(new SqlParameter("ProductID", id));

                    Console.WriteLine("Commands executed! Total rows affected are " + updateCommand.ExecuteNonQuery());
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DisplayProductDetails()
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";

                SqlCommand command;
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    command = new SqlCommand("Select * from Product ", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t | {2} \t\t\t | {3}\t\t\t ",
                                "ProductID", "ProductName", "Price", "CategoryID"));

                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t | {2} \t\t\t | {3}\t\t\t ",
                                reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DisplayCategoryDetails()
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";

                SqlCommand command;
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    command = new SqlCommand("Select * from Category ", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t",
                                "CategoryID", "CategoryName"));

                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t",
                                reader[0], reader[1]));
                        }
                    }
                    Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DisplayProductDetailsBasedOnID(int id)
        {
            try //same
            {
                string connectionString =
               "Data Source=DEL1-LHP-N82172;Initial Catalog=ProductManagement;Integrated Security=True";

                SqlCommand command;
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();
                    command = new SqlCommand("Select * from Product where ProductID = @ProductID ", connection);
                    command.Parameters.Add(new SqlParameter("ProductID", id));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t | {2} \t\t\t | {3}\t\t\t ",
                                "ProductID", "ProductName", "Price", "CategoryID"));

                        while (reader.Read())
                        {
                            Console.WriteLine(String.Format("{0} \t\t\t | {1} \t\t\t | {2} \t\t\t | {3}\t\t\t ",
                                reader[0], reader[1], reader[2], reader[3]));
                        }
                    }
                    Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                    Console.WriteLine("Done! Press enter to move to the next step");
                    Console.ReadLine();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}