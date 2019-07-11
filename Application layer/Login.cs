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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            Admin user1 = new Admin();
            user1.AId = tboxlogin.Text;
            user1.APassword = tboxpass.Text;
            AdminRepository adRepo = new AdminRepository();

            Owner user2 = new Owner();
            user2.OId = tboxlogin.Text;
            user2.OPassword = tboxpass.Text;
            OwnerRepository adRepo1 = new OwnerRepository();

            Customer user3 = new Customer();
            user3.CId = tboxlogin.Text;
            user3.CPassword = tboxpass.Text;
            CustomerRepository adRepo2 = new CustomerRepository();







            if (adRepo.UserLoginValidation(user1))
            {
                String aidd = tboxlogin.Text;
                AdminHome h = new AdminHome();
                h.AdminHome1(aidd);
                h.Show();
                this.Hide();               
            }


            else if (adRepo1.UserLoginValidation(user2))
            {
                String oidd = tboxlogin.Text;
                OwnerHome h = new OwnerHome();
                h.OwnerHome1(oidd);
                h.Show();
                this.Hide();
            }



            else if (adRepo2.UserLoginValidation(user3))
            {
                String cidd = tboxlogin.Text;
                CustomerHome h = new CustomerHome();
                h.CustomerHome1(cidd);
                h.Show();
                this.Hide();
            }





            else
            {
                MessageBox.Show("Invalid Id or Password", "Login Failed");
            }



        }



        private void reglbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRegistration cr = new CustomerRegistration();
            cr.Show();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {

                this.WindowState = FormWindowState.Minimized;

            }

        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

            this.Close();
           


           
        }

        private void title1_Click(object sender, EventArgs e)
        {

        }


        }
    }

