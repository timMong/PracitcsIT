using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic_9
{
  public partial class Form1 : Form
  {
    //Point[] points = new Point[50];
    Pen pen = new Pen(Color.Black, 2);
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Image img = Image.FromFile(@"D:\Documents\БББО-06-19\ИТ\Practic_9\озеро.jpg");
      Graphics g = e.Graphics;
      g.DrawImage(img, 0, 0, 800, 500);
      // body
      SolidBrush myBrush1 = new SolidBrush(Color.Coral);
      RectangleF[] rects = { new RectangleF(300, 120, 60, 200) };
      int x1 = 270, x2 = 325, x3 = 300;
      int y1 = 300, y2 = 300, y3 = 90;
      int width1 = 60;
      int height1 = 60;
      e.Graphics.FillEllipse(myBrush1, x1, y1, width1, height1);
      e.Graphics.FillEllipse(myBrush1, x2, y2, width1, height1);
      e.Graphics.FillEllipse(myBrush1, x3, y3, width1, height1);
      e.Graphics.FillRectangles(myBrush1, rects);
      SolidBrush myBrush2 = new SolidBrush(Color.Red);
      // big wings
      int x4 = 100, x5 = 360;
      int y4 = 180, y5 = 180;
      int width2 = 200;
      int height2 = 150;
      e.Graphics.FillEllipse(myBrush2, x4, y4, width2, height2);
      e.Graphics.FillEllipse(myBrush2, x5, y5, width2, height2);
      // small wings
      int x6 = 200, x7 = 360;
      int y6 = 120, y7 = 120;
      int width3 = 100;
      int height3 = 70;
      e.Graphics.FillEllipse(myBrush2, x6, y6, width3, height3);
      e.Graphics.FillEllipse(myBrush2, x7, y7, width3, height3);
      // mustache
      Pen blackPen = new Pen(Color.Black, 3);
      RectangleF rect1 = new RectangleF(320, 300, 50, 200); // left
      float startAngle1 = 100;
      float sweepAngle1 = 150;
      e.Graphics.DrawArc(blackPen, rect1, startAngle1, sweepAngle1);
      RectangleF rect2 = new RectangleF(290, 325, 50, 200);// reight
      float startAngle2 = 1000;
      float sweepAngle2 = 150;
      e.Graphics.DrawArc(blackPen, rect2, startAngle2, sweepAngle2);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      
    }
  }
}
