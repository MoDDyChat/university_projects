using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab43
{
    class Example3
    {
        Side[] sides;
        PointF[] points;
        Double[,] m = new double[3, 3];

        public void FillSide()
        {
            sides = new Side[6] { new Side(new Vertex(200, 200, 200), new Vertex(300, 200, 200), new Vertex(300, 200, 300), new Vertex(200, 200, 300)),
            new Side(new Vertex(200, 200, 300), new Vertex(200, 300, 300), new Vertex(300, 300, 300), new Vertex(300, 200, 300)),
            new Side(new Vertex(200, 200, 300), new Vertex(200, 300, 300), new Vertex(200, 300, 200), new Vertex(200, 200, 200)),
            new Side(new Vertex(200, 200, 200), new Vertex(200, 300, 200), new Vertex(300, 300, 200), new Vertex(300, 200, 200)),
            new Side(new Vertex(300, 200, 200), new Vertex(300, 200, 300), new Vertex(300, 300, 300), new Vertex(300, 300, 200)),
            new Side(new Vertex(200, 300, 300), new Vertex(200, 300, 200), new Vertex(300, 300, 200), new Vertex(300, 300, 300))};
        }

        public Vertex RotateVertex(double factX, double factY, double factZ, Vertex vertex)
        {
            m[0, 0] = Math.Cos(factY) * Math.Cos(factZ);
            m[0, 1] = -Math.Cos(factY) * Math.Sin(factZ);
            m[0, 2] = -Math.Sin(factY);
            m[1, 0] = Math.Sin(factX) * Math.Sin(factY) * Math.Cos(factZ) + Math.Sin(factZ) * Math.Cos(factX);
            m[1, 1] = -Math.Sin(factX) * Math.Sin(factY) * Math.Sin(factZ) + Math.Cos(factZ) * Math.Cos(factX);
            m[1, 2] = Math.Cos(factY);
            m[2, 0] = -Math.Cos(factX) * Math.Sin(factY) * Math.Cos(factZ) + Math.Sin(factX) * Math.Sin(factZ);
            m[2, 1] = Math.Cos(factX) * Math.Sin(factY) * Math.Sin(factZ) + Math.Sin(factX) * Math.Cos(factZ);
            m[2, 2] = Math.Cos(factY) * Math.Cos(factX);

            double newX = m[0, 0] * vertex.x + m[1, 0] * vertex.y + m[2, 0] * vertex.z;
            double newY = m[0, 1] * vertex.x + m[1, 1] * vertex.y + m[2, 1] * vertex.z;
            double newZ = m[0, 2] * vertex.x + m[1, 2] * vertex.y + m[2, 2] * vertex.z;
            return new Vertex(newX, newY, newZ);
        }
        
        public Side RotateSide(double factX, double factY, double factZ, Side side)
        {
            Vertex newX1 = RotateVertex(factX, factY, factZ, side.x1);
            Vertex newX2 = RotateVertex(factX, factY, factZ, side.x2);
            Vertex newX3 = RotateVertex(factX, factY, factZ, side.x3);
            Vertex newX4 = RotateVertex(factX, factY, factZ, side.x4);

            return new Side(newX1, newX2, newX3, newX4);
        }

        public void DrawShape(Graphics graphic, double factX, double factY, double factZ, int Width, int Height, bool isFill)
        {
            Pen[] myPen = new Pen[6] { new Pen(Color.Blue, 1), new Pen(Color.Red, 1), new Pen(Color.Black, 1), new Pen(Color.Purple, 1), new Pen(Color.Orchid, 1), new Pen(Color.Green, 1), };
            Brush[] myBrush = new SolidBrush[6] { new SolidBrush(Color.Blue), new SolidBrush(Color.Red), new SolidBrush(Color.Black), new SolidBrush(Color.Purple), new SolidBrush(Color.Orchid), new SolidBrush(Color.Green), };

            for (int i = 0; i < 6; i++)
            {
                Side newX = RotateSide(factX, factY, factZ, sides[i]);
                points = new PointF[4] {new PointF(Convert.ToSingle(newX.x1.x), Convert.ToSingle(newX.x1.y)),
                new PointF(Convert.ToSingle(newX.x2.x), Convert.ToSingle(newX.x2.y)),
                new PointF(Convert.ToSingle(newX.x3.x), Convert.ToSingle(newX.x3.y)),
                new PointF(Convert.ToSingle(newX.x4.x), Convert.ToSingle(newX.x4.y))};
                FillMode newFillMode = new FillMode();
                newFillMode = FillMode.Winding;
                graphic.DrawPolygon(myPen[i], points);
                if (isFill)
                    graphic.FillPolygon(myBrush[i], points);
            }
            int Xstart, Ystart;
            Xstart = Width / 2;
            Ystart = Height / 2;

            Matrix myMatrix = new Matrix();
            myMatrix.Translate(Xstart, Ystart);
            graphic.Transform = myMatrix;
            
        }

    }
}
