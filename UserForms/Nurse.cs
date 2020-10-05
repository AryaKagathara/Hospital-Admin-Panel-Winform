﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.UserForms
{
    public partial class Nurse : Form
    {
        Users u = new Users();
        public Nurse()
        {
            InitializeComponent(); 
            if (SessionClass.SessionId == 0)
            {
                Login_Form f1 = new Login_Form(0);
                f1.ShowDialog();
            }

            label1.Text = "        " + SessionClass.SessionId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button1.Top;
            duserdetails.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            u.Logout();
            Login_Form f1 = new Login_Form(0);
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Top = button2.Top;
            diet.BringToFront();
        }
    }
}
