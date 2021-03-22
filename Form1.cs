using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Монгуш Т.Ш.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения номера 6.";

 }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double x = double.Parse(s);
            double y1, y2, res;
            y1 = (Math.Pow(x, 3 / 2) - Math.Log(x)) / (Math.Cos(2 * (Math.Pow(x, 2))) + Math.Abs(x - 3));
            y2 = (3 * Math.Pow(x - 2, 2)) / (Math.Log(x) + 2);
            res = y1 + y2;
            textBox2.Text = "Практическая работа №2 Монгуш Т.Ш.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения номер 6.\n";
            textBox2.Text += Environment.NewLine + "При x = " + x;
            textBox2.Text += Environment.NewLine + "Результат y = " + res.ToString();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
