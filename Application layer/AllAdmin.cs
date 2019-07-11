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
    public partial class AllAdmin : Form
    {
        public AllAdmin()
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
            OwnerHome oh = new OwnerHome();
            oh.Show();
        }

        private void AllAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMSDataSet1.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.rMSDataSet1.Admin);

        }
    }
}
