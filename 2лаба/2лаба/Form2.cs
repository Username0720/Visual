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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form3 aForm = new Form3();
            aResult = aForm.ShowDialog();
            if(aResult == DialogResult.OK)
            {
                MessageBox.Show("Ur name" + aForm.textBox1.Text + " " + aForm.textBox2.Text);
                MessageBox.Show("Ur addres" + aForm.textBox3.Text);
                MessageBox.Show("Ur phone number" + aForm.maskedTextBox1.Text);
            }
            linkLabel1.LinkVisited = true;
        }
    }
}
