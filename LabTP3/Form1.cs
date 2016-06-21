using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTP3
{
    public partial class Form1 : Form
    {
        public delegate double operation(double x, double y);

        double plus(double x, double y) { return x + y; }
        double minus(double x, double y) { return x - y; }
        double division(double x, double y) { return x / y; }
        double multiply(double x, double y) { return x * y; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation oper = new operation(plus);

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double result = oper(a, b);

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation oper = new operation(minus);

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double result = oper(a, b);

            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation oper = new operation(multiply);

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double result = oper(a, b);

            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation oper = new operation(division);

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double result = oper(a, b);

            textBox3.Text = result.ToString();
        }
    }
}
