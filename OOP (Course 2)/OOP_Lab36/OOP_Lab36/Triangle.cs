using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab36
{
    class Triangle : Shape
    {
        Point point1;
        Point point2;
        Point point3;

        public Triangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }

        public override void Paint(Graphics g)
        {
            point1 = new Point(this.x, this.y);
            point2 = new Point(this.x + this.width, this.y);
            point3 = new Point(this.x + this.width / 2, this.y - this.height);
            Point[] points = { point1, point2, point3 };
            g.FillPolygon(new SolidBrush(this.color), points);
            g.DrawPolygon(new Pen(Color.Gray, 1), points);
            if (isSelected)
                g.DrawPolygon(new Pen(Color.Black, 3), points);
        }

        private int Area(Point p1, Point p2, Point p3)
        {
            return Math.Abs((p1.X - p3.X) * (p2.Y - p3.Y) + (p2.X - p3.X) * (p3.Y - p1.Y));
        }

        public override bool lookAtShape(int x, int y)
        {
            Point point4 = new Point(x, y);
            if (Area(point1, point2, point3) == Area(point1, point2, point4) + Area(point1, point4, point3) + Area(point2, point4, point3))
                return true;
            return false;
        }

        public override bool borderCheck(int borderX, int borderY, bool isUp)
        {
            if (isUp)
            {
                if (borderX == -1 && this.y - this.height <= borderY)
                    return true;
                else if (borderY == -1 && this.x <= borderX)
                    return true;
            }
            else
            {
                if (borderX == -1 && this.y >= borderY)
                    return true;
                else if (borderY == -1 && this.x + this.width >= borderX)
                    return true;
            }
            return false;
        }
    }
}
