using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class Bezier : Shape
    {
        List<Point> _points;

        public Bezier(List<Point> points, Color color)
        {
            _points = new List<Point>(points);   
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            graphic.DrawBeziers(new Pen(this.color, 2), _points.ToArray());
            //Console.WriteLine(this.points.);
        }
    }
}
