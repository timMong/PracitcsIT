using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Fact(int a)
        {
            if (a == 0) return 1;
            else return a * Fact(a - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double eps = Convert.ToDouble(textBox1.Text);
            textBox2.Text = "Результаты работы программы ст. Монгуш Т.Ш. " + Environment.NewLine;
            int vibor = 0;
            if (radioButton2.Checked) vibor = 1;
            double sum = 0, multi = 1, u;
            int n = 0;
            switch (vibor)
            {
                case 0:
                    do
                    {
                        u = (2 * n + 1) / Fact(3 * n + 1);
                        if (u < eps) break;
                        sum += u;
                        n++;
                    } while (u > eps);
                    textBox2.Text += "При тоночти = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Сумма ряда S = " + Convert.ToString(sum) + Environment.NewLine;
                    u = 0;
                    break;
                case 1:
                    for(int i = 0; i <= eps; i++)
                    { 
                        u = Math.Sqrt(Fact(3 * i + 1));
                        multi *= u;
                    } 
                    u = 0;
                    textBox2.Text += "При верхнем пределе eps = " + textBox1.Text + Environment.NewLine;
                    textBox2.Text += "Произведение ряда P = " + Convert.ToString(multi) + Environment.NewLine;
                    break;
            }
        }
    }
}
