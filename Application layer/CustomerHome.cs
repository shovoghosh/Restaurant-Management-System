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
    public partial class CustomerHome : Form
    {

        private string ciddd;
        private string Username = string.Empty;

        public CustomerHome()
        {
            InitializeComponent();
            
            
            
        }

        public void CustomerHome1(string cidd)
        {
            this.ciddd = cidd;

            CustomerRepository _DataAccess = new CustomerRepository();
            Username = _DataAccess.ReturnUserName(ciddd);
            
            
            
        }


        

        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login lg = new Login();
            lg.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CProfile cp = new CProfile(ciddd);
            cp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer mc = new ManageCustomer();
            mc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            COrderHistory ch = new COrderHistory();
            ch.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodPage fp = new FoodPage();
            fp.Show();
        }


        private void CustomerHome_Load(object sender, EventArgs e)
        {
            
            lblcname.Text = Username + " ";
            
        }
    }
}
