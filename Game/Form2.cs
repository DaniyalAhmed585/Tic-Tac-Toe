﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string setvaluefortext1 = "";
        public static string setvaluefortext2 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                setvaluefortext1 = textBox1.Text;
                setvaluefortext2 = textBox2.Text;
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Fill two of the above fields.", "ERROR", MessageBoxButtons.OK);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
        }
    }
}
