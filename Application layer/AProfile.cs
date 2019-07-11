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
using System.IO;

namespace Application_layer
{
    public partial class AProfile : Form
    {
        private string AId;

        public AProfile()
        {
            InitializeComponent();
        }

        public AProfile(string AId)
        {
            InitializeComponent();
            this.AId = AId;
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
            ah.ShowDialog();
        }

        private void AProfile_Load(object sender, EventArgs e)
        {
            AdminRepository aRepo = new AdminRepository();
            List<Admin> aList = aRepo.GetAdmin(AId);
           

            foreach (Admin admin in aList)
            {

                aname.Text = admin.AName;
                aidd.Text = admin.AId;
                aemaill.Text = admin.AEmail;
                aphonee.Text = admin.APhone;
                apass.Text = admin.APassword;
               

                
            }


        }
    }
}
