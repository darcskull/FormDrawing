using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace курсов_проект
{
    [Serializable]
   public class Triangle : Shape
    {
        public override double CalculateSurface()
        {
            return Size * Size * Math.Sqrt(3) / 4;
        }
        public override double CalculatePerimeter()
        {
            return 3 * Size;
        }

        public override void Draw(int x, int y, int size)
        {
            Graphics g = FormScene.ActiveForm.CreateGraphics();
            Brush b = new SolidBrush(Color);
            Point[] points = { new Point(x - size , y + size ),
                               new Point(x + size , y + size ),
                               new Point(x , y - size ), };
            g.FillPolygon(b, points);
            base.Draw(x, y, size);
        }
        public override bool IsClicked(int xx, int yy)
        {
            if (PointInTriangle(new Point(xx, yy),
                                new Point(x - Size, y + Size),
                                new Point(x + Size, y + Size),
                                new Point(x, y - Size)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool PointInTriangle(Point pt, Point v1, Point v2, Point v3)
        {
            float d1, d2, d3;
            bool intr, intrr;

            d1 = Sign(pt, v1, v2);
            d2 = Sign(pt, v2, v3);
            d3 = Sign(pt, v3, v1);

            intr = (d1 < 0) || (d2 < 0) || (d3 < 0);
            intrr = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(intr && intrr);
        }
        float Sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
    }
}
