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
    public partial class ASalary : Form
    {
        public ASalary()
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
            ah.ShowDialog();
        }
    }
}
