using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class GraphicPath : Shape
    {
        List<Point> _points;
        LinearGradientBrush linColor = new LinearGradientBrush(new Point(0, 10), new Point(300, 400), Color.Red, Color.Blue);

        public GraphicPath(List<Point> points)
        {
            _points = new List<Point>(points);
        }

        public override void Paint(Graphics graphic)
        {
            GraphicsPath GPath = new GraphicsPath();
            GPath.AddPolygon(_points.GetRange(0, 4).ToArray());
            GPath.AddPolygon(_points.GetRange(4, 4).ToArray());
            graphic.FillPath(linColor, GPath);
        }
    }
}
