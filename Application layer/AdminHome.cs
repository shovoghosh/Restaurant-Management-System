using Repository;
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

namespace Application_layer
{
    public partial class AdminHome : Form
    {
        private string AId;

        public AdminHome()
        {
            InitializeComponent();
            
            
        }


        public void AdminHome1(string aidd)
        {
            this.AId = aidd;

            AdminRepository _DataAccess = new AdminRepository();

            Username = _DataAccess.ReturnUserName(aidd);
           
        }


        public string Username = string.Empty;




        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ViewAllProducts aamf = new ViewAllProducts();
            aamf.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asetting ma = new Asetting();
            ma.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ASalary aas = new ASalary();
            aas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AManageOrder aM = new AManageOrder();
            aM.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ViewSales aas = new ViewSales();
            aas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AProfile aaf = new AProfile(AId);
            aaf.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AManageOwner aoo = new AManageOwner();
            aoo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCustomers amc = new AllCustomers();
            amc.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void foodpage_Click(object sender, EventArgs e)
        {
            FoodPage fp = new FoodPage();
            fp.Show();
        }



        private void AdminHome_Load(object sender, EventArgs e)
        {

            lblAid.Text = Username + " ";



        }


        private void button8_Click(object sender, EventArgs e)
        {
            FoodOption fo = new FoodOption();
            fo.Show();
        }


        
    }
}
