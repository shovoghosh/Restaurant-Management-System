using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repository
{
   public class FoodRepository : IFoodRepository
    {

       string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";


       public bool AddNewCategoryToDatabase(string CategoryName, string CategoryDescription, PictureBox CategoryPictureBox)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();


               /*Start a local transaction*/
               SqlTransaction sqlTran = connection.BeginTransaction();

               /*Enlist a command in the current transaction*/
               SqlCommand command = connection.CreateCommand();
               command.Transaction = sqlTran;

               MemoryStream ms = new MemoryStream();

               /*saving the image in raw format from picture box*/
               CategoryPictureBox.Image.Save(ms, CategoryPictureBox.Image.RawFormat);

               /*Array of Binary numbers that have been converted*/
               byte[] CategoryPicture = ms.GetBuffer();

               /*closing the memory stream*/
               ms.Close();

               /*HASHING END HERE*/

               /*now we will save this array into our database*/



               try
               {
                   // Execute separate commands.
                   command.Parameters.AddWithValue("@CategoryName", CategoryName);
                   command.Parameters.AddWithValue("@CategoryDescription", CategoryDescription);
                   command.Parameters.AddWithValue("@CategoryPicture", CategoryPicture);

                   command.CommandText =
                      "Insert into Categories (CategoryName, CategoryDescription, CategoryPicture) values (@CategoryName, @CategoryDescription, @CategoryPicture)";
                   command.ExecuteNonQuery();

                   // Commit the transaction.
                   sqlTran.Commit();

                   connection.Close();

                   return true;
               }
               catch (Exception ee)
               {
                   connection.Close();
                   return false;
               }
           }
       }




       public ArrayList RetreiveAllCategoriesFromDatabase()
       {
           ArrayList CategoriesList = new ArrayList();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT ID, CategoryName, CategoryPicture FROM Categories;", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       int CategoryID = reader.GetInt32(0);
                       string CategoryName = reader.GetString(1);
                       byte[] CategoryPicture = (byte[])reader[2];

                       CategoriesList.Add(new Food() { FId = CategoryID, FCategory = CategoryName, CPicture = CategoryPicture });
                   }
               }
               reader.Close();

               return CategoriesList;
           }
       }




       public bool AddNewProductToDatabase(string foodName, decimal foodPrice, int foodCategoryID, string foodDescription, byte[] foodPicture)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();

               /*Start a local transaction*/
               SqlTransaction sqlTran = connection.BeginTransaction();

               /*Enlist a command in the current transaction*/
               SqlCommand command = connection.CreateCommand();
               command.Transaction = sqlTran;

               try
               {
                   // Execute separate commands.
                   command.Parameters.AddWithValue("@FName", foodName);
                   command.Parameters.AddWithValue("@FPrice", foodPrice);
                   command.Parameters.AddWithValue("@FCategoryID", foodCategoryID);
                   command.Parameters.AddWithValue("@FDescription", foodDescription);
                   command.Parameters.AddWithValue("@FImage", foodPicture);

                   command.CommandText =
                      "Insert into Food (FName, FPrice, FCategoryID, FDescription, FImage) values (@FName, @FPrice, @FCategoryID, @FDescription, @FImage)";
                   command.ExecuteNonQuery();

                   // Commit the transaction.
                   sqlTran.Commit();

                   connection.Close();

                   return true;
               }
               catch (Exception ee)
               {
                   connection.Close();
                   return false;
               }
           }
       }


       public ArrayList RetreiveAllProducts()
       {
           ArrayList ProductsList = new ArrayList();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT FId, FName, FPrice, FCategoryID, FDescription, FImage FROM Food;", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       int foodID = reader.GetInt32(0);
                       string foodName = reader.GetString(1);
                       decimal foodPrice = reader.GetDecimal(2);
                       int foodCategoryID = reader.GetInt32(3);
                       string foodCategoryName = ReturnCategoryName(foodCategoryID);
                       string foodDescription = reader.GetString(4);
                       byte[] foodPicture = (byte[])reader[5];

                       ProductsList.Add(new Food() { FName = foodName, FPrice = foodPrice, FCategory = foodCategoryName, FDescription = foodDescription, FPicture = foodPicture, FId = foodID });

                   }
               }
               reader.Close();

               return ProductsList;
           }
       }



       public ArrayList RetreiveProductsFromCategory(int CategoryID)
       {
           ArrayList ProductsList = new ArrayList();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT FID, FName, FPrice, FDescription, FImage FROM Food where FCategoryID = '" + CategoryID + "';", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       int foodID = reader.GetInt32(0);
                       string foodName = reader.GetString(1);
                       decimal foodPrice = reader.GetDecimal(2);
                       string foodDescription = reader.GetString(3);
                       byte[] foodPicture = (byte[])reader[4];

                       ProductsList.Add(new Food() { FId = foodID, FName = foodName, FPrice = foodPrice, FPicture = foodPicture, FDescription = foodDescription });
                   }
               }
               reader.Close();

               return ProductsList;
           }
       }



       public int ReturnCategoryID(string CategoryName)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT ID FROM Categories where CategoryName = '" + CategoryName + "';", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               int CategoryID = 0;

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       CategoryID = reader.GetInt32(0);
                   }
               }
               reader.Close();

               return CategoryID;
           }
       }



       public string ReturnCategoryName(int CategoryID)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT CategoryName FROM Categories where ID = '" + CategoryID + "';", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               string CategoryName = string.Empty;

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       CategoryName = reader.GetString(0);
                   }
               }
               reader.Close();

               return CategoryName;
           }
       }


       public Food RetreiveProductDetails(int ProductID)
       {
           Food FoodDetails = new Food();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT  FName, FPrice,FCategoryID, FDescription, FImage FROM Food where FId = '" + ProductID + "';", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       FoodDetails.FName = reader.GetString(0);
                       FoodDetails.FPrice = reader.GetDecimal(1);
                       int foodCategoryID = reader.GetInt32(2);
                       FoodDetails.FCategory = ReturnCategoryName(foodCategoryID);
                       FoodDetails.FDescription = reader.GetString(3);
                       FoodDetails.FPicture = (byte[])reader[4];
                   }
               }
               reader.Close();

               return FoodDetails;
           }
       }



       public bool DeleteProduct(int ProductID)
       {
           try
           {
               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                   SqlCommand command = new SqlCommand("Delete from Food where FId = '" + ProductID + "'", connection);
                   connection.Open();

                   if (command.ExecuteNonQuery() > 0)
                   {
                       connection.Close();
                       return true;
                   }
                   else return false;
               }
           }
           catch (Exception)
           {
               return false;
           }
       }



       public bool UpdateProduct(int foodID, string foodName, decimal foodPrice, int foodCategoryID, string foodDescription, byte[] foodPicture)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();

               /*Start a local transaction*/
               SqlTransaction sqlTran = connection.BeginTransaction();

               /*Enlist a command in the current transaction*/
               SqlCommand command = connection.CreateCommand();
               command.Transaction = sqlTran;

               try
               {
                   // Execute separate commands.
                   command.Parameters.AddWithValue("@FId", foodID);
                   command.Parameters.AddWithValue("@FName", foodName);
                   command.Parameters.AddWithValue("@FPrice", foodPrice);
                   command.Parameters.AddWithValue("@FCategoryID", foodCategoryID);
                   command.Parameters.AddWithValue("@FDescription", foodDescription);
                   command.Parameters.AddWithValue("@FImage", foodPicture);

                   command.CommandText =
                      "Update Food set FId = @FId, FPrice = @FPrice, FCategoryID = @FCategoryID, FDescription = @FDescription, FImage=@FImage where FId = @FId";
                   command.ExecuteNonQuery();

                   // Commit the transaction.
                   sqlTran.Commit();

                   connection.Close();

                   return true;
               }
               catch (Exception ee)
               {
                   connection.Close();
                   return false;
               }
           }
       }


       public bool UpdateCategory(int CategoryID, string CategoryName, string CategoryDescription, byte[] CategoryPicture)
       {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();

               /*Start a local transaction*/
               SqlTransaction sqlTran = connection.BeginTransaction();

               /*Enlist a command in the current transaction*/
               SqlCommand command = connection.CreateCommand();
               command.Transaction = sqlTran;

               try
               {
                   // Execute separate commands.
                   command.Parameters.AddWithValue("@Id", CategoryID);
                   command.Parameters.AddWithValue("@CategoryName", CategoryName);           
                   command.Parameters.AddWithValue("@CategoryDescription", CategoryDescription);
                   command.Parameters.AddWithValue("@CategoryPicture", CategoryPicture);

                   command.CommandText =
                      "Update Categories set  CategoryName = @CategoryName, CategoryDescription = @CategoryDescription, CategoryPicture=@CategoryPicture where ID = @Id";
                   command.ExecuteNonQuery();

                   // Commit the transaction.
                   sqlTran.Commit();

                   connection.Close();

                   return true;
               }
               catch (Exception ee)
               {
                   connection.Close();
                   return false;
               }
           }
       }



       public bool RecordASale(ArrayList ProductsList, DateTime SaleTime, decimal CashGiven, decimal TotalBill, decimal CashReturn)
       {
           int SaleID = ReturnSaleID();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();

               /*Start a local transaction*/
               SqlTransaction sqlTran = connection.BeginTransaction();

               /*Enlist a command in the current transaction*/
               SqlCommand command = connection.CreateCommand();
               command.Transaction = sqlTran;

               try
               {
                   // Execute separate commands.
                   command.Parameters.AddWithValue("@SaleTime", SaleTime);
                  
                   command.Parameters.AddWithValue("@CashGiven", CashGiven);
                   command.Parameters.AddWithValue("@TotalBill", TotalBill);
                   command.Parameters.AddWithValue("@CashReturn", CashReturn);

                   command.CommandText =
                      "Insert into Sales (SaleTime, CashGiven, TotalBill, CashReturn) values (@SaleTime,  @CashGiven, @TotalBill, @CashReturn)";
                   command.ExecuteNonQuery();

                   foreach (Food ProductDetail in ProductsList)
                   {
                       //// Execute separate commands.
                       //command.Parameters.AddWithValue("@ProductName", ProductDetail.Name);
                       //command.Parameters.AddWithValue("@ProductPrice", ProductDetail.Price);
                       //command.Parameters.AddWithValue("@ProductQuantity", ProductDetail.Quantity);
                       //command.Parameters.AddWithValue("@ProductTotal", ProductDetail.Total);
                       //command.Parameters.AddWithValue("@SaleID", SaleID);

                       command.CommandText =
                          "Insert into SaleItems (ProductName, ProductPrice, ProductQuantity, ProductTotal, SaleID) values ('" + ProductDetail.FName + "', '" + ProductDetail.FPrice + "', '" + ProductDetail.FQuantity + "', '" + ProductDetail.Total + "', '" + SaleID + "')";
                       command.ExecuteNonQuery();
                   }

                   // Commit the transaction.
                   sqlTran.Commit();

                   connection.Close();

                   return true;
               }
               catch (Exception ee)
               {
                   connection.Close();
                   return false;
               }
           }
       }



       public int ReturnSaleID()
       {
           int SaleID = 1;
           try
           {

               using (SqlConnection connection = new SqlConnection(connectionString))
               {
                   SqlCommand command = new SqlCommand("SELECT MAX(ID) FROM Sales;", connection);
                   connection.Open();

                   SqlDataReader reader = command.ExecuteReader();

                   if (reader.HasRows)
                   {
                       while (reader.Read())
                       {
                           SaleID = reader.GetInt32(0);
                       }
                   }
                   reader.Close();

                   SaleID = SaleID + 1;

                   return SaleID;
               }
           }
           catch (Exception)
           {
               return SaleID;
           }
       }




       public ArrayList RetreiveAllSales()
       {
           ArrayList SalesList = new ArrayList();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT ID, SaleTime, TotalBill FROM Sales;", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       int SaleID = reader.GetInt32(0);
                       DateTime SaleTime = reader.GetDateTime(1);
                       //int SalesmanID = reader.GetInt32(2);
                      // string SalesmanName = ReturnUserName(SalesmanID);
                       decimal TotalBill = reader.GetDecimal(2);

                       SalesList.Add(new Food() { SaleID = SaleID, SaleTime = SaleTime, Total = TotalBill });
                   }
               }
               reader.Close();

               return SalesList;
           }
       }



       public ArrayList RetreiveSaleItems(int SaleID)
       {
           ArrayList ProductsList = new ArrayList();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand("SELECT ProductName, ProductPrice, ProductQuantity, ProductTotal FROM SaleItems where SaleID = '" + SaleID + "';", connection);
               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       string ProductName = reader.GetString(0);
                       decimal ProductPrice = reader.GetDecimal(1);
                       int ProductQuantity = reader.GetInt32(2);
                       decimal ProductTotal = reader.GetDecimal(3);

                       ProductsList.Add(new Food() { FName = ProductName, FPrice = ProductPrice, FQuantity = ProductQuantity, Total = ProductTotal });
                   }
               }
               reader.Close();

               return ProductsList;
           }
       }




    }
}
