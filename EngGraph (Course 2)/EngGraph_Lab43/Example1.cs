using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngGraph_Lab43
{
    class Example1
    {
        Double[] x0 = new double[3];
        Double[] y0 = new double[3];
        Double[] z0 = new double[3];

        Double[] x1 = new double[3];
        Double[] y1 = new double[3];
        Double[] z1 = new double[3];

        PointF[] points = new PointF[3];

        

        public Example1()
        {
            x0[0] = 500;
            x0[1] = 450;
            x0[2] = 510;

            y0[0] = 600;
            y0[1] = 550;
            y0[2] = 470;

            z0[0] = 500;
            z0[1] = 470;
            z0[2] = 490;
        }
        
        public Double RotatePitch(double x, double y, double z, double alpha, int i)
        {
            x1[i] = x;
            y1[i] = y * Math.Cos(alpha) - z * Math.Sin(alpha);
            return y * Math.Sin(alpha) + z * Math.Cos(alpha);
        }

        public Double RotateYaw(double x, double y, double z, double alpha, int i)
        {
            x1[i] = x * Math.Cos(alpha) + z * Math.Sin(alpha);
            y1[i] = y;
            return -x * Math.Sin(alpha) + z * Math.Cos(alpha);
        }

        public Double RotateRoll(double x, double y, double z, double alpha, int i)
        {
            x1[i] = x * Math.Cos(alpha) - y * Math.Sin(alpha);
            y1[i] = x * Math.Sin(alpha) + y * Math.Cos(alpha);
            return z;
        }

        public void DrawShape(Graphics graphic, int Axis, double factX, double factY, double factZ)
        {
            if (Axis == 0)
            {
                z1[0] = this.RotatePitch(x0[0], y0[0], z0[0], factX, 0);
                z1[1] = this.RotatePitch(x0[1], y0[1], z0[1], factX, 1);
                z1[2] = this.RotatePitch(x0[2], y0[2], z0[2], factX, 2);
            }
            else if (Axis == 1)
            {
                z1[0] = this.RotateYaw(x0[0], y0[0], z0[0], factY, 0);
                z1[1] = this.RotateYaw(x0[1], y0[1], z0[1], factY, 1);
                z1[2] = this.RotateYaw(x0[2], y0[2], z0[2], factY, 2);
            }
            else if (Axis == 2)
            {
                z1[0] = this.RotateRoll(x0[0], y0[0], z0[0], factZ, 0);
                z1[1] = this.RotateRoll(x0[1], y0[1], z0[1], factZ, 1);
                z1[2] = this.RotateRoll(x0[2], y0[2], z0[2], factZ, 2);
            }

            x0[0] = x1[0];
            y0[0] = y1[0];
            z0[0] = z1[0];

            x0[1] = x1[1];
            y0[1] = y1[1];
            z0[1] = z1[1];

            x0[2] = x1[2];
            y0[2] = y1[2];
            z0[2] = z1[2];

            points[0] = new PointF(Convert.ToSingle(x1[0]), Convert.ToSingle(y1[0]));
            points[1] = new PointF(Convert.ToSingle(x1[1]), Convert.ToSingle(y1[1]));
            points[2] = new PointF(Convert.ToSingle(x1[2]), Convert.ToSingle(y1[2]));

            //graphic.Clear(Color.White);
            graphic.DrawPolygon(new Pen(Color.Red, 2), points);
            graphic.FillPolygon(new SolidBrush(Color.Blue), points);
        }
    }
}
