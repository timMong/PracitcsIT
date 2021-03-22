using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем номер выделенной строки
            int index = listBox1.SelectedIndex;
            // Считываем строку в перменную str
            string str = (string)listBox1.Items[index];
            // Узнаем количество символов в строке
            int len = str.Length;
            // Считаем, что количество цифр равно 0
            int count = 0;
            char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //Организуем цикл перебора всех символов в строке
            for (int i = 0; i < len; i++)
            {
               foreach (char num in Numbers)
               {
                    textBox1.Text += "str[i] = " + str[i] + Environment.NewLine;
                    textBox1.Text += "num = " + num + Environment.NewLine;
                    textBox1.Text += "count = " + count + Environment.NewLine;

                    if (str[i] == num)
                    {
                      count++;
                      break;
                    }
               }
            }
              label1.Text = "Количество цифр = " + count.ToString();
              str = null;
              count = len = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
