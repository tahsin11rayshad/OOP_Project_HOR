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
    public partial class Search_UI : Form
    {
        public Search_UI()
        {
            InitializeComponent();
        }

        private void searchui_home_button_Click(object sender, EventArgs e)
        {
            HomePage suihomepage= new HomePage();
            suihomepage.Show();
            this.Hide();
        }
    }
}
