using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_layer
{
    public partial class FoodOption : Form
    {
        public FoodOption()
        {
            InitializeComponent();
        }


        private void ac_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }


        private void uc_Click(object sender, EventArgs e)
        {
            UpdateCategorys uc = new UpdateCategorys();
            uc.Show();
        }


        private void af_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();


        }


       
    }
}
