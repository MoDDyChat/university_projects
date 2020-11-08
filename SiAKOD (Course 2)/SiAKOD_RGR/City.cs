using System;
using System.Collections.Generic;
using System.Drawing;

namespace SiAKOD_RGR
{
    class City : Shape
    {
        public int X;
        public int Y;

        public int Width;
        public int Height;

        public string Text;
        List<Road> Roads;

        public float Value;
        public float ValueSum;
        public bool isChecked;
        public City prevCity;
        public Color Color;

        public City(int x, int y, int width, int height, string text, float value, bool ischecked, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text;
            Color = color;

            Value = value;
            isChecked = ischecked;

            Roads = new List<Road>();
        }

        public City()
        {

        }

        public void RemoveRoad(Road Road)
        {
            Roads.Remove(Road);
        }

        public void AddRoad(Road Road)
        {
            Roads.Add(Road);
        }

        public bool HasLink(City City)
        {
            if (City == this)
                return false;

            foreach (var Road in Roads)
                if (Road.HasCity(City))
                    return true;

            return false;
        }

        public Road getLink(City City)
        {
            foreach (var Road in Roads)
                if (Road.HasCity(City))
                    return Road;

            return null;
        }

        public void RemoveLinks()
        {
            while (Roads.Count > 0)
                Roads[0].DeleteSelf();
        }


        public override bool isPointInFigure(int x, int y)
        {
            return Math.Pow(x - this.X, 2) / Math.Pow(Width / 2, 2) + Math.Pow(y - this.Y, 2) / Math.Pow(Height / 2, 2) <= 1;
        }

        public override void Paint(Graphics g)
        {
            var brush = new SolidBrush(Color);
            var x1 = X - (Width / 2);
            var y1 = Y - (Height / 2);

            g.FillEllipse(brush, x1, y1, Width, Height);

            var font = new Font(FontFamily.GenericSansSerif, 16);
            var font2 = new Font(FontFamily.GenericSerif, 9);
            var font3 = new Font(FontFamily.GenericSerif, 9);
            g.DrawString(Text, font, new SolidBrush(Color.Black), X - 8, Y - 8);
            if (Value != 999999)
                g.DrawString(Value.ToString(), font2, new SolidBrush(Color.Black), X - 16, Y - 16);
            g.DrawString(ValueSum.ToString(), font3, new SolidBrush(Color.Blue), X + 20, Y + 20);

            if (Selected)
            {
                var pen = new Pen(Color.Red, 3);
                g.DrawEllipse(pen, x1, y1, Width, Height);
            }
        }
    }
}
