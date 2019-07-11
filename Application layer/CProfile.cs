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
    public partial class CProfile : Form
    {
        private string ciddd;

        public CProfile()
        {
            InitializeComponent();
        }

        public CProfile(string ciddd)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.ciddd = ciddd;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome ch = new CustomerHome();
            ch.Show();
        }


        private void CProfile_Load(object sender, EventArgs e)
        {

            CustomerRepository cRepo = new CustomerRepository();
            List<Customer> CList = cRepo.Getcustomer(ciddd);


            foreach (Customer custo in CList)
            {

                cname.Text = custo.CName;
                cid.Text = custo.CId;
                cemail.Text = custo.CEmail;
                cphone.Text = custo.CPhone;
                cpass.Text = custo.CPassword;



            }


        }
    }
}
