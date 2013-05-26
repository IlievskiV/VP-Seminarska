using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace IQ_Test
{
    //Класа во која се чуваат податоци за исцртување на скалилото
    class IQScaleResult
    {
        public int IQCoef { get; set; }
        public int Xcoef { get; set; }
        public int Ycoef { get; set; }
        public Color Color { get; set; }


        public IQScaleResult(int iqcoef, int xcoef, int ycoef)
        {
            IQCoef = iqcoef;
            Xcoef = xcoef;
            Ycoef = ycoef;
            Color = Color.LightYellow;
        }

        //функција за испртување на скалилото
        public void Draw(Graphics g)
        {
            Point p1 = new Point(20, 200);
            Point p2 = new Point(20, 220);
            Point p3 = new Point(560, 220);
            Point p4 = new Point(560, 50);

            Point p7 = new Point(21, 200);
            Point p8 = new Point(21, 220);
            Point p5 = new Point(Xcoef, Ycoef);
            Point p6 = new Point(Xcoef, 220);

            Brush brush = new SolidBrush(Color.Black);
            Brush brush2 = new SolidBrush(Color);

            Pen pen = new Pen(brush);

            Point[] points1 = { p1, p2, p3, p4 };
            Point[] points2 = { p7, p8, p6, p5 };
 
            g.DrawPolygon(pen, points1);
            g.FillPolygon(brush2, points2);

            brush.Dispose();
            brush2.Dispose();
        }

        public void increaseCoordinates(int xcoef)
        {
            Xcoef = xcoef;
            Ycoef = ((Xcoef - 20) * (-150) / 540) + 200;
        }

    }
}