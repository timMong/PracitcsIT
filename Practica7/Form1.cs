using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* int row = 0, column = 0, i, j;
             string str = textBox1.Text;
             char[] arr = new char[str.Length+2];
             str.CopyTo(0, arr, 0, str.Length);
             for (j = 0; j < 9; j++)
             {
                 textBox2.Text = "arr[0] = " + arr[0];  
                 if (Convert.ToInt32(arr[0]) == j)
                     row = j + 1;
                 if (Convert.ToInt32(arr[3]) == j)
                     column = j + 1;
             }
             dataGridView1.RowCount = row; //Указываем количество строк
             dataGridView1.ColumnCount = column; //Указываем количество столбцов
             int[,] a = new int[5, 5]; //Инициализируем массив
             //Заполняем матрицу случайными числами
             Random rand = new Random();
             for (i = 0; i < row; i++) 
                 for (j = 0; j < column; j++)
                     a[i, j] = rand.Next(0, 0);
             //Выводим матрицу в dataGridView1
             for (i = 0; i < row; i++)
                 for (j = 0; j < column; j++)
                     dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
             //производим поиск максимального элемента на дополнительной диагонали
             int m = int.MinValue;
             for (i = 0; i < row; i++)
                 if (a[i, column - i] > m)
                     m = a[i, column - i];*/

            dataGridView1.RowCount = 5; //Указываем количество строк
            dataGridView1.ColumnCount = 5; //Указываем количество столбцов
            int[,] a = new int[5, 5]; //Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 5; i++) 
                for (j = 0; j < 5; j++)
                    a[i, j] = rand.Next(-100, 100);
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            //производим поиск максимального элемента на дополнительной диагонали
            int min = int.MaxValue;
            int max = int.MinValue;
            int i1 = 0, i2 = 0;
            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++)
                {
                    if (a[i, j] < min)
                    {
                        i1 = i;
                        min = a[i, j];
                    }
                    if (a[i, j] > max)
                    {
                        i2 = i;
                        max = a[i, j];
                    } 
                }
            dataGridView2.RowCount = 1; //Указываем количество строк
            dataGridView2.ColumnCount = 5;
            int[,] a2 = new int[1, 5];
            textBox2.Text = "i1 = " + i1 + " | i2 = " + i2;  
            //Заполняем матрицу числами
            for (i = 0; i < 5; i++)
                a2[0, i] = a[i1, i] + a[i2, i];
            //Выводим матрицу в dataGridView1
            for (j = 0; j < 5; j++)
                dataGridView2.Rows[0].Cells[j].Value = Convert.ToString(a2[0, j]);
            // выводим результат

        }
    }
}
