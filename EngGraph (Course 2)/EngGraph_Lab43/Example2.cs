using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab43
{
    class Example2
    {
        Double[] x0 = new double[3];
        Double[] y0 = new double[3];
        Double[] z0 = new double[3];

        Double[] x1 = new double[3];
        Double[] y1 = new double[3];
        Double[] z1 = new double[3];

        Double[,] m = new double[3, 3];

        PointF[] points = new PointF[3];

        public Example2()
        {
            x0[0] = 200;
            x0[1] = 300;
            x0[2] = 100;

            y0[0] = 100;
            y0[1] = 300;
            y0[2] = 100;
        }

        public Double RotateShape(double x, double y, double z, double factX, double factY, double factZ, int i)
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

            x1[i] = m[0, 0] * x + m[1, 0] * y + m[2, 0] * z;
            y1[i] = m[0, 1] * x + m[1, 1] * y + m[2, 1] * z;
            return m[0, 2] * x + m[1, 2] * y + m[2, 2] * z;
        }

        public void DrawShape(Graphics graphic, double factX, double factY, double factZ)
        {
            z1[0] = this.RotateShape(x0[0], y0[0], z0[0], factX, factY, factZ, 0);
            z1[1] = this.RotateShape(x0[1], y0[1], z0[1], factX, factY, factZ, 1);
            z1[2] = this.RotateShape(x0[2], y0[2], z0[2], factX, factY, factZ, 2);

            points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
            points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
            points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

            //graphic.Clear(Color.White);
            graphic.DrawPolygon(new Pen(Color.Red, 2), points);
            graphic.FillPolygon(new SolidBrush(Color.Blue), points);
        }

    }
}
