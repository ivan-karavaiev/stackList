using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karavaev
{
    class StartBuild : MyRandom
    {
        public int radius;
        public const int maxN = 35;
        public StartBuild()
        {
            this.radius = 20;
        }
        public StartBuild(int radius)
        {
            this.radius = radius;
        }
        string toString(int n)
        {
            string str = "";
            while(n != 0)
            {
                str = (n % 10) + str;
                n /= 10;
            }
            return str;
        }
        Graphics DrawIcons(Graphics gr, Point p, int number)
        {
            string str = toString(number);
            Image img = Image.FromFile("Picture/Graph_0_" + str + ".bmp");
            RectangleF rct = new RectangleF(p.X - radius, p.Y - radius, 40, 40);
            gr.DrawImage(img, rct);
            return gr;
        }

        public Graphics DrawString(Graphics gr, String str, Point coordinate)
        {
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            gr.DrawString(str, drawFont, drawBrush, coordinate);
            return gr;
        }
        public Graphics DrawRound(Graphics gr, Pen pen, Point center, int index)
        {
            pen.Width = 2;
            gr.DrawEllipse(pen, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Point coordinate = new Point(center.X - 10, center.Y - 10);
            if (index + 1 >= 10) coordinate.X -= 5;
            gr.DrawString(toString(index + 1), drawFont, drawBrush, coordinate);
            return gr;
        }
        public Point updateMousePosition(Point mp)
        {
            return new Point(mp.X - 189, mp.Y - 161);
        }

        float dist(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        PointF findCoeff(float x1, float y1, float x2, float y2)
        {
            // y = kx + t; return(k, t);
            // (x - x1) / (x2 - x1) = (y - y1) / (y2 - y1); -->
            // y = (y2 - y1) * x / (x2 - x1) + (x2 * y1 - x1 * y2) / (x2 - x1);
            float k = (y2 - y1) / (x2 - x1);
            float t = (x2 * y1 - x1 * y2) / (x2 - x1);
            return new PointF(k, t);
        }
        List < PointF > findPointIntersection(Point p1, Point p2)
        {
            float x1 = p1.X, x2 = p2.X, y1 = p1.Y, y2 = p2.Y;
            PointF L = findCoeff(x1, y1, x2, y2);
            float k = L.X, t = L.Y;

            List<PointF> pIntersection = new List<PointF>();
            // x^2 * (k^2 + 1) + x * 2(k(t - b) - a) + a^2 + (t - b)^2 - R^2
            float a, b, A, B, C;
            float D, xPoint, yPoint;

            // first
            a = x1; b = y1;
            A = k * k + 1; B = 2 * (k * (t - b) - a);
            C = a * a + (t - b) * (t - b) - radius * radius;
            D = B * B - 4 * A * C;
            xPoint = (-B + (float)Math.Sqrt(D)) / (2 * A);
            yPoint = k * xPoint + t;
            pIntersection.Add(new PointF(xPoint, yPoint));
            xPoint = (-B - (float)Math.Sqrt(D)) / (2 * A);
            yPoint = k * xPoint + t;
            pIntersection.Add(new PointF(xPoint, yPoint));

            // second
            a = x2; b = y2;
            A = k * k + 1; B = 2 * (k * (t - b) - a);
            C = a * a + (t - b) * (t - b) - radius * radius;
            D = B * B - 4 * A * C;
            xPoint = (-B + (float)Math.Sqrt(D)) / (2 * A);
            yPoint = k * xPoint + t;
            pIntersection.Add(new PointF(xPoint, yPoint));
            xPoint = (-B - (float)Math.Sqrt(D)) / (2 * A);
            yPoint = k * xPoint + t;
            pIntersection.Add(new PointF(xPoint, yPoint));

            return pIntersection;
        }

        public Graphics DrawEdge(Graphics gr, Pen pen, Point сenter1, Point center2)
        {
            pen.Width = 1;
            //
            List < PointF > pIntersection = findPointIntersection(сenter1, center2);
            //
            float minDist = 1000;
            Point index = new Point();
            for(int i = 0; i < 2; ++i)
            {
                for(int j = 2; j < 4; ++j)
                {
                    float length = dist(pIntersection[i], pIntersection[j]);
                    if (length < minDist){
                        minDist = length;
                        index.X = i; index.Y = j;
                    }
                }
            }
            gr.DrawLine(pen, pIntersection[index.X], pIntersection[index.Y]);
            return gr;
        }
        bool segmentIntersection(int x1, int y1, int x2, int y2)
        {
            int maxX = x1; if (x2 > x1) maxX = x2;
            int minY = y1; if (y2 < y1) minY = y2;
            return maxX <= minY;
        }

        public bool squareIntersection(Point p1, Point p2)
        {
            bool Intersection = true;
            int crdi = p1.X, crdj = p2.X;
            Intersection &= segmentIntersection(crdi - radius, crdi + radius,
                                                crdj - radius, crdj + radius);
            crdi = p1.Y;  crdj = p2.Y;
            Intersection &= segmentIntersection(crdi - radius, crdi + radius,
                                                crdj - radius, crdj + radius);
            return Intersection;
        }
    }
}
