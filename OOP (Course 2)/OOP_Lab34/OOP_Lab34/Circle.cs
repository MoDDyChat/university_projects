using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab34
{
    public class Circle : Shape
    {
        public int radius;

        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Paint(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Yellow), x, y, radius, radius);
            g.DrawEllipse(new Pen(Color.Gray, 1), x, y, radius, radius);
            if (isSelected)
                g.DrawEllipse(new Pen(Color.Black, 3), x, y, radius, radius);
        }
    }
}
