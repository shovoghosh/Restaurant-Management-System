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
    public partial class OwnerHome : Form
    {
        

        public OwnerHome()
        {
            InitializeComponent();
        }

        string oid;
        public void OwnerHome1(string oidd)
        {
            this.oid = oidd;
            
            OwnerRepository _DataAccess = new OwnerRepository();

            Username = _DataAccess.ReturnUserName(oid);
        }

        public string Username = string.Empty;



        private void titladmin_Click(object sender, EventArgs e)
        {

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
            OProfile op = new OProfile(oid);
            op.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageOwner mo = new ManageOwner();
            mo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ViewSales ms = new ViewSales();
            ms.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ViewAllProducts mf = new ViewAllProducts();
            mf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageOrder mo = new ManageOrder();
            mo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.Hide();
            AllAdmin aa = new AllAdmin();
            aa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AllCustomers ac = new AllCustomers();
            ac.Show();
        }

        private void ofoodpage_Click(object sender, EventArgs e)
        {
            FoodPage fp = new FoodPage();
            fp.Show();
        }

        private void OwnerHome_Load(object sender, EventArgs e)
        {
            lblname.Text = Username + " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FoodOption fo = new FoodOption();
            fo.Show();
        }
    }
}
