using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num;
        char opt;
        double op1, op2;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 1;
            textBox1.Text = num.ToString("G");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 2;
            textBox1.Text = num.ToString("G");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 3;
            textBox1.Text = num.ToString("G");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 4;
            textBox1.Text = num.ToString("G");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 5;
            textBox1.Text = num.ToString("G");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 6;
            textBox1.Text = num.ToString("G");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 7;
            textBox1.Text = num.ToString("G");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 8;
            textBox1.Text = num.ToString("G");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 9;
            textBox1.Text = num.ToString("G");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num = ulong.Parse(textBox1.Text);
            num = num * 10 + 0;
            textBox1.Text = num.ToString("G");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            opt = '+';
            op1 = ulong.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            opt = '-';
            op1 = ulong.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            opt = '*';
            op1 = ulong.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            opt = '/';
            op1 = ulong.Parse(textBox1.Text);
            textBox1.Text = "0";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            op2 = ulong.Parse(textBox1.Text);
            switch (opt) 
            {
                case '+': result = op1 + op2; break;
                case '-': result = op1 - op2; break;
                case '*': result = op1 * op2; break;
                case '/': result = op1 / op2; break;

            }
            
            textBox1.Text = result.ToString("G");
        }

    }
}
