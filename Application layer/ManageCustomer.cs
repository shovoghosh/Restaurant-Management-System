﻿using System;
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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome ch = new CustomerHome();
            ch.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHome ch = new CustomerHome();
            ch.Show();
        }
    }
}
