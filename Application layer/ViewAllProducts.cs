using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using System.Data.SqlClient;

namespace Application_layer
{
    public partial class ViewAllProducts : Form
    {
        public ViewAllProducts()
        {
            InitializeComponent();
        }



        private void ViewAllProducts_Load(object sender, EventArgs e)
        {

            FoodRepository _DataAccess = new FoodRepository();

            ProductCategoryComboBox.Items.Add("All Categories");

            foreach (Food CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.FCategory);
            }

            ProductCategoryComboBox.SelectedIndex = 0;

        }



        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProductsGridView.Rows.Clear();

            if (ProductCategoryComboBox.SelectedIndex == 0)
            {
                FoodRepository _DataAccess = new FoodRepository();

                foreach (Food ProductDetail in _DataAccess.RetreiveAllProducts())
                {
                    ProductsGridView.Rows.Add(ProductDetail.FId, ProductDetail.FName, ProductDetail.FPrice, ProductDetail.FCategory, ProductDetail.FDescription, ProductDetail.FPicture);
                }
            }
            else if (ProductCategoryComboBox.SelectedIndex > 0)
            {
                string CategoryName = ProductCategoryComboBox.SelectedItem.ToString();

                FoodRepository _DataAccess = new FoodRepository();

                int CategoryID = _DataAccess.ReturnCategoryID(CategoryName);

                foreach (Food ProductDetail in _DataAccess.RetreiveProductsFromCategory(CategoryID))
                {
                    ProductsGridView.Rows.Add(ProductDetail.FId, ProductDetail.FName, ProductDetail.FPrice, CategoryName, ProductDetail.FDescription, ProductDetail.FPicture);
                }
            }

        }



        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteProductColumn")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product\nfrom Database", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);

                        FoodRepository _DataAccess = new FoodRepository();

                        if (_DataAccess.DeleteProduct(ProductID))
                        {
                            ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        }
                        else if (!_DataAccess.DeleteProduct(ProductID))
                        {
                            MessageBox.Show("Product Not Deleted");
                        }
                    }
                }
                else if (ProductsGridView.Columns[e.ColumnIndex].Name == "EditProductColumn")
                {
                    int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);

                    string ProductName = ProductsGridView.Rows[e.RowIndex].Cells["ProductNameColumn"].Value.ToString();

                    decimal ProductPrice = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["ProductPriceColumn"].Value.ToString());

                    string ProductCategory = ProductsGridView.Rows[e.RowIndex].Cells["ProductCategoryColumn"].Value.ToString();

                    string ProductDescription = ProductsGridView.Rows[e.RowIndex].Cells["ProductDescriptionColumn"].Value.ToString();

                    byte[] ProductPicture = (byte[])ProductsGridView.Rows[e.RowIndex].Cells["ProductImageColumn"].Value;

                    UpdateProucts UpdateProductForm = new UpdateProucts(ProductID, ProductName, ProductPrice, ProductCategory, ProductDescription, ProductPicture);

                    if (UpdateProductForm.ShowDialog() == DialogResult.OK)
                    {
                        FoodRepository _DataAccess = new FoodRepository();

                        Food UpdatedProductDetail = _DataAccess.RetreiveProductDetails(ProductID);

                        ProductsGridView.Rows[e.RowIndex].Cells["ProductNameColumn"].Value = UpdatedProductDetail.FName;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductPriceColumn"].Value = UpdatedProductDetail.FPrice;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductCategoryColumn"].Value = UpdatedProductDetail.FCategory;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductDescriptionColumn"].Value = UpdatedProductDetail.FDescription;
                        ProductsGridView.Rows[e.RowIndex].Cells["ProductImageColumn"].Value = UpdatedProductDetail.FPicture;
                    }
                }
            }



        }

        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikon\Desktop\Our Project\Restaurant Management System\Repository\RMS.mdf;Integrated Security=True;Connect Timeout=30";

        
        
        private void searchbox_TextChanged(object sender, EventArgs e)
        {

            try

            {
                

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("select FId, FName, FPrice, FDescription,FImage  FROM Food where FName like '" + searchbox.Text + "%'", connection);
        
                SqlDataReader reader = command.ExecuteReader();

                

                    if (reader.HasRows)
                    {
                        ProductsGridView.Rows.Clear();
                        while (reader.Read() == true)
                        {
                           
                            ProductsGridView.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                    }


                    connection.Close();
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        







    }
}
