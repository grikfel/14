using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            if (a + b > c && a + c > b && c + b > a)
            {
                if (a == b && a == c)
                    label2.Text = "Треугольник равносторонний";
                else if ((a == b) || (a == c) || (b == c))
                    label2.Text = "Треугольник равнобедренный";
                else label2.Text = "Треугольник разносторонний";
            }
            else label2.Text = "Треугольника не существует";
        }
    }
}
