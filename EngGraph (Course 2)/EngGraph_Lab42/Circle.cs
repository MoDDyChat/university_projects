using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class Circle : Shape
    {
        public int Width;
        public int Height;

        public Circle(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.Width = width;
            this.Height = height;
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            graphic.DrawEllipse(new Pen(this.color, 2), x, y, Width, Height);
        }
    }
}
