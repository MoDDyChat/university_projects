using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class Line : Shape
    {
        Point point1;
        Point point2;

        public Line(Point p1, Point p2, Color color)
        {
            point1 = p1;
            point2 = p2;
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            Point[] points = { point1, point2 };
            graphic.DrawPolygon(new Pen(this.color, 2), points);
        }
    }
}
