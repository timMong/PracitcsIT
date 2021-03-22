using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form1 : Form
    {
        int[] arr = new int[15];
        public Form1()
        {
            InitializeComponent();
            label1.AutoSize = false;
            label1.Paint += Label1_Paint;
            label3.Text = "Элементов, которые 0 < x < 7:";
        }

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.RotateTransform(-90);
            SizeF textSize = e.Graphics.MeasureString(label1.Text, label1.Font);
            label1.Width = (int)textSize.Height + 2;
            label1.Height = (int)textSize.Width + 2;
            e.Graphics.TranslateTransform(-label1.Height / 2, label1.Width / 2);
            e.Graphics.DrawString(label1.Text, label1.Font, Brushes.Black, -(textSize.Width / 2), -(textSize.Height / 2));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                + Convert.ToString(arr[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < 15; i++)
            {
                if (arr[i] > 0 && arr[i] < 7)
                    count++;
            }
            label2.Text = Convert.ToString(count);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
