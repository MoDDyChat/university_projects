using System;
using System.Drawing;

namespace SiAKOD_RGR_Nail
{
    public class Edge : Shape
    {
        public Vertex First;
        public Vertex Second;
        public float Weight;
        public Color color;

        public bool isDeleted = false;

        public Edge(Vertex first, Vertex second, Color color_)
        {
            First = first;
            Second = second;
            color = color_;

            First.AddEdge(this);
            Second.AddEdge(this);
        }

        public override bool isPointInFigure(int x, int y)
        {
            var x1 = First.X;
            var y1 = First.Y;
            var x2 = Second.X;
            var y2 = Second.Y;
            var distance =
                Math.Abs((y2 - y1) * x - (x2 - x1) * y + x2 * y1 - y2 * x1)
                / Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));

            return distance < 5;
        }

        public bool HasVertex(Vertex Vertex)
        {
            return Vertex == First || Vertex == Second;
        }

        public override void Paint(Graphics g)
        {
            var pen = new Pen(color, 3);

            if (Selected)
                pen.Color = Color.Red;
            int strX, strY;
            var font = new Font(FontFamily.GenericSansSerif, 12);
            if (First.X < Second.X)
                strX = First.X + (Second.X - First.X) / 2 + 10;
            else
                strX = Second.X + (First.X - Second.X) / 2 + 10;
            if (First.Y < Second.Y)
                strY = First.Y + (Second.Y - First.Y) / 2 - 25;
            else
                strY = Second.Y + (First.Y - Second.Y) / 2 - 25;

            g.DrawLine(pen, First.X, First.Y, Second.X, Second.Y);
        }

        public void DeleteSelf()
        {
            First.RemoveEdge(this);
            Second.RemoveEdge(this);
            isDeleted = true;
        }
    }
}
