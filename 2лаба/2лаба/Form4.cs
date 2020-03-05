using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2лаба
{
    public partial class Form4 : Form
    {
        int operation = -1;
        double result;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "3";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "0";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "1";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "2";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "4";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "5";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "6";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "7";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "8";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += "9";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                textBox1.Text = "";
                operation = -1;
            }
            textBox1.Text += ",";
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            operation = 1;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            operation = 2;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            operation = 3;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
            operation = 4;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                textBox2.Text = textBox1.Tag +" + " + textBox1.Text + "=";
                result = Convert.ToDouble(textBox1.Tag) + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == 2)
            {
                textBox2.Text = textBox1.Tag + " - " + textBox1.Text + "=";
                result = Convert.ToDouble(textBox1.Tag) - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == 3)
            {
                textBox2.Text = textBox1.Tag + " * " + textBox1.Text + "=";
                result = Convert.ToDouble(textBox1.Tag) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            if (operation == 4)
            {
                textBox2.Text = textBox1.Tag + " / " + textBox1.Text + "=";
                result = Convert.ToDouble(textBox1.Tag) / Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            operation = 0;
        }
    }
}
