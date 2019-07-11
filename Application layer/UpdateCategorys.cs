using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;

namespace Application_layer
{
    public partial class UpdateCategorys : Form
    {


        string CategoryName, CategoryDescription;
        int CategoryID;
        byte[] CategoryPicture;

       

        public UpdateCategorys()
        {
            InitializeComponent();
        }


        public UpdateCategorys(int GivenCategoryID, string GivenCategoryName, string GivenCategoryDescription, byte[] GivenCategoryPicture)
        {


            CategoryID = GivenCategoryID;
            CategoryName = GivenCategoryName;
            CategoryDescription = GivenCategoryDescription;
            CategoryPicture = GivenCategoryPicture;
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want to Update this Category?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FoodRepository _DataAccess = new FoodRepository();

               

               

                string ProductCategory = ProductCategoryComboBox.Text;
                string CategoryName = newcategoryname.Text;

                int CategoryID = _DataAccess.ReturnCategoryID(ProductCategory);

                string CategoryDescription = categoryDescriptionRBox.Text;

                /*initializing memory stream class for creating a stream of binary numbers*/
                MemoryStream ms = new MemoryStream();

                /*saving the image in raw format from picture box*/
                categoryPictureBox.Image.Save(ms, categoryPictureBox.Image.RawFormat);

                /*Array of Binary numbers that have been converted*/
                byte[] MyProductPicture = ms.GetBuffer();

                /*closing the memory stream*/
                ms.Close();

                if (_DataAccess.UpdateCategory(CategoryID, CategoryName, CategoryDescription,  MyProductPicture))
                {
                    this.Close();
                }
                else MessageBox.Show("Product Not Updated", "Error", MessageBoxButtons.OK);
            }

        }



        private void UpdateCategorys_Load(object sender, EventArgs e)
        {

            categoryidtbox.Text = CategoryID.ToString();
            ProductCategoryComboBox.Text = CategoryName;
            categoryDescriptionRBox.Text = CategoryDescription;

          //  MemoryStream ms = new MemoryStream(CategoryPicture);
           // categoryPictureBox.Image = Image.FromStream(ms);

            FoodRepository _DataAccess = new FoodRepository();

            foreach (Food CategoryDetail in _DataAccess.RetreiveAllCategoriesFromDatabase())
            {
                ProductCategoryComboBox.Items.Add(CategoryDetail.FCategory);
            }

        }



        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            /*selecting image*/

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image file..";
            ofd.DefaultExt = ".jpg";
            ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                /*if picture selected then load in the picture box*/
                categoryPictureBox.Load(ofd.FileName);
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
