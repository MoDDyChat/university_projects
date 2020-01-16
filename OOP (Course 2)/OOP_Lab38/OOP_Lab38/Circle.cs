using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace OOP_Lab38
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
            if (isSticky)
                g.FillEllipse(new SolidBrush(Color.LightGreen), x, y, width, height);
            if (isSelected)
                g.DrawEllipse(new Pen(Color.Black, 3), x, y, width, height);
        }

        public override bool lookAtShape(int x, int y)
        {
            int oX = x - this.width / 2;
            int oY = y - this.height / 2;
            if (Math.Pow(oX - this.x, 2) / Math.Pow(this.width / 2, 2) + Math.Pow(oY - this.y, 2) / Math.Pow(this.height / 2, 2) <= 1)
                return true;
            return false;
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("C");
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
                if(borderX == -1 && this.y + this.height + 4 >= borderY)
                    return true;
                else if (borderY == -1 && this.x + this.width + 3 >= borderX)
                    return true;
            }
            return false;
        }
    }
}
