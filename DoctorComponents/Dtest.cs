﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Dtest : UserControl
    {
        DoctorFunctions df = new DoctorFunctions();
        public Dtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PID = textBox2.Text;
            string Tests = richTextBox1.Text;
            if (PID.Equals("") || Tests.Equals(""))
                MessageBox.Show("Enter valid data","Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                df.AddTestDetails(PID,Tests);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void richTextBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                string tmp = richTextBox1.Text + ",";
                richTextBox1.Text = tmp;
                richTextBox1.Select(richTextBox1.Text.Length, 0);
            }
        }
    }
}
