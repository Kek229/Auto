using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            data.a=textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.m == true)
            {
                Form3 form3 = new Form3();  
                form3.Show();
                data.m = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            data.b=textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            data.c=textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            data.d=textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            data.e=textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            data.f=textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            data.g=textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            data.h=textBox8.Text;
        }
    }
}
