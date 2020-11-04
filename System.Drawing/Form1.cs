using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen pen = new Pen(Color.Red, 3);
            //pen.DashStyle = Drawing2D.DashStyle.Dot;
            //g.DrawEllipse(pen, 50, 100, 200, 200);

            //Rectangle rect = new Rectangle(20, 20, 200, 50);
            //LinearGradientBrush gradBrash = new LinearGradientBrush(rect, Color.Green, Color.Yellow, 0, true);
            //g.FillRectangle(gradBrash, rect);


            //Rectangle rect2 = new Rectangle(20, 80, 200, 50);
            //HatchBrush hatchBrush = new HatchBrush(HatchStyle.DarkHorizontal, Color.Yellow);
            //g.FillRectangle(hatchBrush, rect2);

            //Rectangle rect3 = new Rectangle(20, 140, 200, 50);
            //TextureBrush textureBrush = new TextureBrush(new Bitmap("1.jpg"));
            //g.FillRectangle(textureBrush, rect3);


            //Font f = new Font("Verdana", 14, FontStyle.Italic);
            //g.DrawString("Hello World", f, Brushes.Red, 30, 30);


            //Rectangle imageRec = new Rectangle(20, 20, 300, 300);
            //Rectangle imageRec = this.ClientRectangle;
            //Image img = new Bitmap("2.jpg");
            //g.DrawImage(img, imageRec);

            //Pen pen = new Pen(Color.Green, 5);
            //g.DrawLine(pen, 20, 20, 160,150);



            Point[] points = {
                new Point(5, 10),
                new Point(23, 130),
                new Point(130, 57)
            };

            //Перша траэкторія
            GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(20, 20, 130,130);

            //Заливка кольором

            //Запускаємо малювання по траєкторії
            //path.StartFigure();

            //Задаэмо точки для траэкторії
            //path.AddCurve(points, 5);
       

            //Закриваэмо траэкторію
            //path.CloseFigure();


            path.StartFigure();

            path.AddArc(50, 50, 150, 90, 0, 170);
            Pen pen = new Pen(Color.Blue, 5);
            g.DrawPath(pen, path);

            path.CloseFigure();


            g.FillPath(Brushes.Pink, path);






            g.Dispose();
        }
    }
}
