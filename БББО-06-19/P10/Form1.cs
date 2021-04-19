using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
{
  public partial class Form1 : Form
  {
    private int x_rec, y_rec, width, height;
    private int x1_trin, x2_trin, x3_trin, y1_trin, y2_trin, y3_trin;
    private int x1_flame, y1_flame, x2_flame, y2_flame, x3_flame, y3_flame, x4_flame, y4_flame, x5_flame, y5_flame, x6_flame, y6_flame;
    private Pen pen = new Pen(Color.Black, 2);
    private SolidBrush brush1 = new SolidBrush(Color.DarkBlue);
    private SolidBrush brush2 = new SolidBrush(Color.Red);
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics rectangle = e.Graphics;
      // Image img = Image.FromFile(@"D:\Documents\БББО-06-19\2.jpg");
      // g.DrawImage(img, 0, 0, 800, 500);
      rectangle.FillRectangle(brush1, x_rec, y_rec, width, height); //рисуем секундную стрелку
      // Массив точек треугольника.
      PointF point1 = new PointF(x1_trin, y1_trin);
      PointF point2 = new PointF(x2_trin, y2_trin);
      PointF point3 = new PointF(x3_trin, y3_trin);
      PointF[] TRINGLE =
      {
        point1,
        point2,
        point3
      };
      e.Graphics.FillPolygon(brush2,TRINGLE);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      x_rec = 290;
      y_rec = 100;
      width = 30;
      height = 120;

      x1_trin = 290; y1_trin = 100;
      x2_trin = 320; y2_trin = 100;
      x3_trin = 305; y3_trin = 50;
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
      //определяем конец часовой стрелки с учетом центра экрана
      y_rec = y_rec - 20;

      y1_trin = y1_trin - 20;
      y2_trin = y2_trin - 20;
      y3_trin = y3_trin - 20;
      Invalidate(); //вынудительный вызов перерисовки (Paint)
    }
  }
}
