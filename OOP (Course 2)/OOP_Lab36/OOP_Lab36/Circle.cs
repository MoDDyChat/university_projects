using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab36
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Paint(Graphics g)
        {
            g.FillEllipse(new SolidBrush(this.color), x, y, width, height);
            g.DrawEllipse(new Pen(Color.Gray, 1), x, y, width, height);
            if (isSelected)
                g.DrawEllipse(new Pen(Color.Black, 3), x, y, width, height);
        }

        public override bool lookAtShape(int x, int y)
        {
            if (Math.Pow(x - this.x, 2) / Math.Pow(this.width / 2, 2) + Math.Pow(y - this.y, 2) / Math.Pow(this.height / 2, 2) <= 1)
                return true;
            return false;
        }
    }
}
