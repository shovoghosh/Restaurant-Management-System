using Repository;
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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

       

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void regcbtn_Click(object sender, EventArgs e)
        {


            CustomerRepository _CustomerRepository = new CustomerRepository();

            bool AdminAddedOrNot = _CustomerRepository.Addcustomer(tbid.Text, tbname.Text, tbpass.Text, tbphone.Text, tbemail.Text, aPictureBox);

            if (AdminAddedOrNot)
            {
                MessageBox.Show("Customer Registered");
            }
            else
                MessageBox.Show("Customer Not Registered");

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
                aPictureBox.Load(ofd.FileName);
            }
        }
    }
}
