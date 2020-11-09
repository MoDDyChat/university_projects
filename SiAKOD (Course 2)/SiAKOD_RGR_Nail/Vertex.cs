using System;
using System.Collections.Generic;
using System.Drawing;

namespace SiAKOD_RGR_Nail
{
    public class Vertex : Shape
    {
        public int X;
        public int Y;

        public int Width;
        public int Height;

        public bool isLeft;
        public bool isChecked;
        public Vertex Link;

        public string Text;
        List<Edge> Edges;
        

        public Color Color;

        public Vertex(int x, int y, int width, int height, string text, Color color, bool isleft)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Text = text;
            Color = color;

            isLeft = isleft;
            isChecked = false;
            Link = null;

            Edges = new List<Edge>();
        }

        public Vertex()
        {

        }

        public void RemoveEdge(Edge Road)
        {
            Edges.Remove(Road);
        }

        public void AddEdge(Edge Road)
        {
            Edges.Add(Road);
        }

        public bool HasLink(Vertex vertex)
        {
            if (vertex == this)
                return false;

            foreach (var Edge in Edges)
                if (Edge.HasVertex(vertex))
                    return true;

            return false;
        }

        public Edge getLink(Vertex vertex)
        {
            foreach (var Edge in Edges)
                if (Edge.HasVertex(vertex))
                    return Edge;

            return null;
        }

        public void RemoveLinks()
        {
            while (Edges.Count > 0)
                Edges[0].DeleteSelf();
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

            var font = new Font(FontFamily.GenericSansSerif, 10);
            g.DrawString(Text, font, new SolidBrush(Color.Black), X - 8, Y - 8);

            if (Selected)
            {
                var pen = new Pen(Color.Red, 3);
                g.DrawEllipse(pen, x1, y1, Width, Height);
            }
        }
    }
}
