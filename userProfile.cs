﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_HOR
{
    public partial class userProfile : Form
    {
        public userProfile()
        {
            InitializeComponent();
        }

        private void h_button_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            h1.Show();
            this.Hide();
        }
    }
}
