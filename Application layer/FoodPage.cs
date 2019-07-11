using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using System.IO;

namespace Application_layer
{
    public partial class FoodPage : Form
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        public int RowIndex = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome ch = new CustomerHome();
            ch.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }




        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            AddCategory _AddCategory = new AddCategory();

            //Retreive CatgeoriesAgain to Show on CategoriesFlow Panel

            if (_AddCategory.ShowDialog() == DialogResult.OK)
            {
                CategoriesFlowPanel.Controls.Clear();

                FoodRepository _DataAccess = new FoodRepository();

                ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

                foreach (Food Category in AllCategories)
                {
                    Button btn = new Button();
                    btn.Text = Category.FCategory;
                    btn.Size = new System.Drawing.Size(80, 80);
                    btn.ForeColor = Color.Black;

                    MemoryStream ms = new MemoryStream(Category.CPicture);
                    btn.Image = Image.FromStream(ms);
                    btn.Image = new Bitmap(btn.Image, btn.Size);

                    btn.Tag = Category.FId;

                    CategoriesFlowPanel.Controls.Add(btn);

                    btn.Click += CategoryButtonClick;
                }
            }


        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            AddProduct _AddProduct = new AddProduct();
            _AddProduct.ShowDialog();


        }

        private void btnviewallproduct_Click(object sender, EventArgs e)
        {
            ViewAllProducts vap = new ViewAllProducts();
            vap.Show();

        }

        private void FoodPage_Load(object sender, EventArgs e)
        {

           
            FoodRepository _DataAccess = new FoodRepository();

            ArrayList AllCategories = _DataAccess.RetreiveAllCategoriesFromDatabase();

            foreach (Food FCategory in AllCategories)
            {
                Button btn = new Button();
                btn.Text = FCategory.FCategory;
                btn.Size = new System.Drawing.Size(80, 80);
                btn.ForeColor = Color.Black;

                MemoryStream ms = new MemoryStream(FCategory.CPicture);
                btn.Image = Image.FromStream(ms);
                btn.Image = new Bitmap(btn.Image, btn.Size);

                btn.Tag = FCategory.FId;

                CategoriesFlowPanel.Controls.Add(btn);

                btn.Click += CategoryButtonClick;
            }


        }


        void CategoryButtonClick(object sender, EventArgs e)
        {
            ProductsFlowPanel.Controls.Clear();

            Button btn = (Button)sender;

            int CategoryID = Convert.ToInt32(btn.Tag);

            FoodRepository _DataAccess = new FoodRepository();

            foreach (Food foods in _DataAccess.RetreiveProductsFromCategory(CategoryID))
            {
                Button ProductButton = new Button();
                ProductButton.Text = foods.FName;
                ProductButton.Size = new System.Drawing.Size(80, 80);
                ProductButton.ForeColor = Color.Black;

                MemoryStream ms = new MemoryStream(foods.FPicture);
                ProductButton.Image = Image.FromStream(ms);
                ProductButton.Image = new Bitmap(ProductButton.Image, ProductButton.Size);

                ProductButton.Tag = foods.FId;

                ProductsFlowPanel.Controls.Add(ProductButton);

                ProductButton.Click += ProductButton_Click;

                //ProductButton.MouseClick += ProductButton_MouseClick;
            }
        }



        void ProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            //for loweing one quantity. do this.. <---------------------
            switch (e.Button)
            {
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Left:
                    MessageBox.Show("Left Click");
                    break;
            }
        }


        void ProductButton_Click(object sender, EventArgs e)
        {
            Button ProductButton = sender as Button;

            FoodRepository _DataAccess = new FoodRepository();

            int ProductID = Convert.ToInt32(ProductButton.Tag);

            Food ProductDetails = _DataAccess.RetreiveProductDetails(ProductID);

            if (CheckProductAlreadyAdded(ProductID))
            {
                // MessageBox.Show("Product Alraedy Exists in Datagrid view at Index : " + RowIndex);
                int Quantity = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value);
                decimal Price = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductPriceColumn"].Value);

                Quantity++;

                /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                double TotalPrice = Convert.ToDouble(Quantity * Price);

                ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["TotalPriceColumn"].Value = TotalPrice;

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, ProductDetails.FName, ProductDetails.FPrice, 1, ProductDetails.FPrice * 1);

                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }


        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }



        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {


            BillPage _CashForm = new BillPage();

            _CashForm.TotalBillBox.Text = TotalBillBox.Text;

            if (_CashForm.ShowDialog() == DialogResult.OK)
            {
                ArrayList ProductsList = new ArrayList();

                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    try
                    {
                        string ProductName = Row.Cells["ProductNameColumn"].Value.ToString();
                        decimal ProductPrice = Convert.ToDecimal(Row.Cells["ProductPriceColumn"].Value);
                        int ProductQuantity = Convert.ToInt32(Row.Cells["ProductQuantityColumn"].Value);
                        decimal ProductTotal = Convert.ToDecimal(Row.Cells["TotalPriceColumn"].Value);

                        ProductsList.Add(new Food() { FName = ProductName, FPrice = ProductPrice, FQuantity = ProductQuantity, Total = ProductTotal });
                    }
                    catch
                    {
                        //means Rows are ended
                    }
                }

                FoodRepository _DataAccess = new FoodRepository();

                if (_DataAccess.RecordASale(ProductsList, DateTime.Now, Convert.ToDecimal(_CashForm.CashGivenBox.Text), Convert.ToDecimal(_CashForm.TotalBillBox.Text), Convert.ToDecimal(_CashForm.CashReturnBox.Text)))
                {
                    MessageBox.Show("Sale Added");
                }
                else MessageBox.Show("Sale Not Added");
            }

        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this Product", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        decimal DeletedProductTotal = Convert.ToDecimal(ProductsGridView.Rows[e.RowIndex].Cells["TotalPriceColumn"].Value);

                        decimal CurrentTotalBill = Convert.ToDecimal(TotalBillBox.Text);

                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;

                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }


        }

        private void ViewAllSales_Click(object sender, EventArgs e)
        {
            ViewSales vs = new ViewSales();
            vs.Show();
        }



        private void updatecategory_Click(object sender, EventArgs e)
        {
            UpdateCategorys uc = new UpdateCategorys();
            uc.Show();
        }




    }
}
