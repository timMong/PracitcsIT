using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica10
{
    public partial class Form1 : Form
    {
        private int x, y, width = 200, hight = 200, r; // x - отдаление от левого края, у - отдаление от верхнего края
                                                       // width, hight - длина и ширина   
        private double a;
        private int x1Line1, y1Line1, x2Line1, y2Line1;
        //private int x1Line2, y1Line2, x2Line2, y2Line2;
        private int count, count2;
        private Brush brush = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(brush, x, y, width, hight); // рисуем мяч
            g.DrawLine(Pens.Black, x1Line1, y1Line1, x2Line1, y2Line1);
            //g.DrawLine(Pens.White, x1Line2, y1Line2, x2Line2, y2Line2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // ЗАДАЕМ НАЧАЛЬНЫЕ ЗНАЧЕНИЯ
            //мячу
            x = 0;
            y = 0;
            width = hight = 60;
            r = 100;// радиус движения
            // земля
            x1Line1 = 0;
            y1Line1 = y2Line1 = 260;
            x2Line1 = ClientSize.Width;
           /* // потолок
            x1Line2 = 0;
            y1Line2 = y2Line2 = 260;
            x2Line2 = ClientSize.Width;
            */
            count = 0;
            count2 = y + width;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (((y + width) <= y1Line1) && count == 0)
            {
                a -= 0.4;//уменьшаем угол на 0,1 радиану
                         //определяем конец часовой стрелки с учетом центра экрана
                x = x + (int)(r * Math.Cos(a));
                y = y - (int)(r * Math.Sin(a));
                count = 0;
            }
            else if (count2 > 0)
            {
                a += 0.4;//уменьшаем угол на 0,1 радиану
                            //определяем конец часовой стрелки с учетом центра экрана
                x = x + (int)(r * Math.Cos(a));
                y = y + (int)(r * Math.Sin(a));
                count = 1;
                count2--; ;
            }*/
            for (int i = 0; i < 2; i++)
            {
                a -= 0.4;//уменьшаем угол на 0,1 радиану
                         //определяем конец часовой стрелки с учетом центра экрана
                x = x + (int)(r * Math.Cos(a));
                y = y - (int)(r * Math.Sin(a));
                Invalidate(); //вынудительный вызов перерисовки (Paint)
            }
            Invalidate(); //вынудительный вызов перерисовки (Paint)
            for (int i = 0; i < 3; i++)
            {
                a += 0.4;//уменьшаем угол на 0,1 радиану
                         //определяем конец часовой стрелки с учетом центра экрана
                x = x + (int)(r * Math.Cos(a));
                y = y + (int)(r * Math.Sin(a));
                Invalidate(); //вынудительный вызов перерисовки (Paint)
            }
        }
    }
}
//определение центра экрана - ClientSize.(Height/Width) / 2;