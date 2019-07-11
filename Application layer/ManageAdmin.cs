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

namespace Application_layer
{
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.Show();
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

    

        private void AddAdmindata_click(object sender, EventArgs e)
        {
            
            AdminRepository _AdminRepository = new AdminRepository();

            bool AdminAddedOrNot = _AdminRepository.AddAdmin(tboxaid.Text, tboxaname.Text, tboxapassword.Text, tboxaphone.Text, tboxaemail.Text, tboxasal.Text, aPictureBox);

            if (AdminAddedOrNot)
            {
                MessageBox.Show("Admin Added");
            }
            else 
                MessageBox.Show("Admin Not Added");

        }

       
        }


    }

