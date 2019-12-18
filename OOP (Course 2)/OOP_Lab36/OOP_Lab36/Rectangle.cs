using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab36
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override void Paint(Graphics g)
        {
            g.FillRectangle(new SolidBrush(this.color), x, y, width, height);
            g.DrawRectangle(new Pen(Color.Gray, 1), x, y, width, height);
            if (isSelected)
                g.DrawRectangle(new Pen(Color.Black, 3), x, y, width, height);
        }

        public override bool lookAtShape(int x, int y)
        {
            if ((x >= this.x - width / 2) && (y >= this.y - height / 2) && (x <= this.x + this.width / 2) && (y <= this.y + this.height / 2))
                return true;
            return false;
        }
    }
}
