using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suma Suma = new suma();

            textBox2.Text = Suma.operar(double.Parse(textBox1.Text), double.Parse(textBox3.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resta Resta = new resta();
            textBox2.Text = Resta.operar(double.Parse(textBox1.Text), double.Parse(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiplicacion mult = new multiplicacion();
            textBox2.Text = mult.operar(double.Parse(textBox1.Text), double.Parse(textBox3.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            division DIVIDE = new division();
            textBox2.Text = DIVIDE.operar(double.Parse(textBox1.Text), double.Parse(textBox3.Text)).ToString();
        }
    }
}
