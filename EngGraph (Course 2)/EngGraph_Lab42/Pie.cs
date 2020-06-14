using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class Pie : Shape
    {
        public int Width;
        public int Height;
        public float startAngle;
        public float endAngle;

        public Pie(int x, int y, int Width, int Height, float startAngle, float endAngle, Color color)
        {
            this.x = x;
            this.y = y;
            this.Width = Width;
            this.Height = Height;
            this.startAngle = startAngle;
            this.endAngle = endAngle;
            this.color = color;
        }

        public override void Paint(Graphics graphic)
        {
            Rectangle rect = new Rectangle(x, y, Width, Height);
            graphic.FillPie(new SolidBrush(Color.Blue), rect, 0, 60);
            graphic.FillPie(new SolidBrush(Color.Red), rect, 60, 90);
            graphic.FillPie(new SolidBrush(Color.Green), rect, 150, 140);
            graphic.FillPie(new SolidBrush(Color.Yellow), rect, 290, 70);
            graphic.DrawEllipse(new Pen(Color.Black, 2), rect);

        }
    }
}
