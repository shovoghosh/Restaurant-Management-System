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
    public partial class OProfile : Form
    {
        private string oid;

        public OProfile()
        {
            InitializeComponent();
        }

        public OProfile(string oid)
        {
            // TODO: Complete member initialization
            this.oid = oid;
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


        private void OProfile_Load(object sender, EventArgs e)
        {


            OwnerRepository oRepo = new OwnerRepository();
            List<Owner> oList = oRepo.Getowner(oid);


            foreach (Owner owner in oList)
            {

                oname.Text = owner.OName;
                oiddd.Text = owner.OId;
                oemail.Text = owner.OEmail;
                ophone.Text = owner.OPhone;
                opass.Text = owner.OPassword;



            }

        }
    }
}
