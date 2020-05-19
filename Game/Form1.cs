using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b1.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b1.Text = "X";
                Rd1.Checked = true;
            }
            b1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b2.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b2.Text = "X";
                Rd1.Checked = true;
            }
            b2.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b9.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b9.Text = "X";
                Rd1.Checked = true;
            }
            b9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b8.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b8.Text = "X";
                Rd1.Checked = true;
            }
            b8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b7.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b7.Text = "X";
                Rd1.Checked = true;
            }
            b7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b6.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b6.Text = "X";
                Rd1.Checked = true;
            }
            b6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b5.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b5.Text = "X";
                Rd1.Checked = true;
            }
            b5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b4.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b4.Text = "X";
                Rd1.Checked = true;
            }
            b4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked == true)
            {
                b3.Text = "O";
                Rd2.Checked = true;
            }
            else if (Rd2.Checked == true)
            {
                b3.Text = "X";
                Rd1.Checked = true;
            }
            b3.Enabled = false;
        }
        int a = 0, b = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (b1.Text != ""||b2.Text!=""||b3.Text!=""||b4.Text!=""||b5.Text!=""||b6.Text!=""||b7.Text!=""||b8.Text!=""||b9.Text!="")
            {
                int i = 0;
                int y = 0;
                if (label1.Text == "")
                    i = 1;
                else if (label1.Text != "")
                {
                    i = Convert.ToInt32 (label1.Text) + 1;
                    a = i;
                }

                int j = 0;
                if (label2.Text == "")
                    j = 1;
                else if (label2.Text != "")
                {
                    j = Convert.ToInt32(label2.Text) + 1;
                    b = j;
                }
                DialogResult dr = new DialogResult();
                if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O" || b4.Text == "O" && b5.Text == "O" && b6.Text == "O"
                    || b7.Text == "O" && b8.Text == "O" && b9.Text == "O" || b1.Text == "O" && b4.Text == "O" && b7.Text == "O"
                    || b2.Text == "O" && b5.Text == "O" && b8.Text == "O" || b3.Text == "O" && b6.Text == "O" && b9.Text == "O"
                    || b1.Text == "O" && b5.Text == "O" && b9.Text == "O" || b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
                {
                    dr = MessageBox.Show("            " + Form1.setvaluefortext1 +" Wins This Round", "                     Round Result", MessageBoxButtons.RetryCancel);
                    if (dr == System.Windows.Forms.DialogResult.Retry)
                    {

                        b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
                        b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = true;
                        Rd1.Checked = true;
                        label1.Text = Convert.ToString(i);
                    }
                    else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X" || b4.Text == "X" && b5.Text == "X" && b6.Text == "X"
                    || b7.Text == "X" && b8.Text == "X" && b9.Text == "X" || b1.Text == "X" && b4.Text == "X" && b7.Text == "X"
                    || b2.Text == "X" && b5.Text == "X" && b8.Text == "X" || b3.Text == "X" && b6.Text == "X" && b9.Text == "X"
                    || b1.Text == "X" && b5.Text == "X" && b9.Text == "X" || b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
                {
                    dr = MessageBox.Show("            "+ Form1.setvaluefortext2 + " Wins This Round", "                     Round Result", MessageBoxButtons.RetryCancel);
                    if (dr == System.Windows.Forms.DialogResult.Retry)
                    {
                        b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
                        b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = true;
                        Rd2.Checked = true;
                        label2.Text = Convert.ToString(j);
                    }
                    else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != "" && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "")
                {
                    if (y == 0)
                    {
                        MessageBox.Show("It's a Tie", "Round Result", MessageBoxButtons.OK);
                        b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
                        b1.Enabled = b2.Enabled = b3.Enabled = b4.Enabled = b5.Enabled = b6.Enabled = b7.Enabled = b8.Enabled = b9.Enabled = true;
                        Rd1.Checked = true;
                    }
                }
            }
            else if (b1.Text == "" && b2.Text == "" && b3.Text == "" && b4.Text == "" && b5.Text == "" && b6.Text == "" && b7.Text == "" && b8.Text == "" && b9.Text == "")
            {
                if (a > 4 && Convert.ToInt32(label1.Text) > 4)
                {
                    MessageBox.Show(Form1.setvaluefortext1 + " Wins", "Final Result", MessageBoxButtons.OK);
                    Application.Exit();
                }
                if (b > 4 && Convert.ToInt32(label2.Text) > 4)
                {
                    MessageBox.Show(Form1.setvaluefortext2 + " Wins", "Final Result", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pl1.Text = Form1.setvaluefortext1;
            Pl2.Text = Form1.setvaluefortext2;
        }

        private void b1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Heading_Click(object sender, EventArgs e)
        {

        }
    }
}
