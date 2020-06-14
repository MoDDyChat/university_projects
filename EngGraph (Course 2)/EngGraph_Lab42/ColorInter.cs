using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class ColorInter : Shape
    {
        List<Point> _points;
        List<Color> colors;
        PathGradientBrush myBrush;
        ColorBlend ColorBl;

        public ColorInter(int x, int y)
        {
            _points = new List<Point>();
            colors = new List<Color>();
            this.x = x;
            this.y = y;
            _points.Add(new Point(x - 100, y - 100));
            _points.Add(new Point(x + 100, y - 100));
            _points.Add(new Point(x + 100, y + 100));
            _points.Add(new Point(x - 100, y + 100));

            colors.Add(Color.Red);
            colors.Add(Color.Yellow);
            colors.Add(Color.Blue);

            List<float> pos = new List<float>();
            pos.Add(0f);
            pos.Add(0.4f);
            pos.Add(1f);

            myBrush = new PathGradientBrush(_points.ToArray());

            ColorBl = new ColorBlend();
            ColorBl.Colors = colors.ToArray();
            ColorBl.Positions = pos.ToArray();
            myBrush.InterpolationColors = ColorBl;

            
        }
        public override void Paint(Graphics graphic)
        {
            graphic.FillRectangle(myBrush, x - 100, y - 100, 200, 200);
        }
    }
}
