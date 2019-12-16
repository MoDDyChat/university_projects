using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab33
{
    public class Shape
    {
        int x;
        int y;
        float area;
        public float radius;
        public float length;
        public const float pi = 3.14f;

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public float Area
        {
            get { return this.area; }
            set { this.area = value; }
        }

        public Shape()
        {
            x = 0;
            y = 0;
        }
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void moveShape(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public virtual void changeLength(float dLength) { }
        public virtual void changeRadius(float dRadius) { }
    };
}
