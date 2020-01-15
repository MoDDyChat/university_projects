using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OOP_Lab38
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
            if ((x >= this.x) && (y >= this.y) && (x <= this.x + this.width) && (y <= this.y + this.height))
                return true;
            return false;
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("R");
            base.Save(sw);
        }

        public override bool borderCheck(int borderX, int borderY, bool isUp)
        {
            if (isUp)
            {
                if (borderX == -1 && this.y <= borderY)
                    return true;
                else if (borderY == -1 && this.x <= borderX)
                    return true;
            }
            else
            {
                if (borderX == -1 && this.y + this.height + 2 >= borderY)
                    return true;
                else if (borderY == -1 && this.x + this.width + 2 >= borderX)
                    return true;
            }
            return false;
        }
    }
}
