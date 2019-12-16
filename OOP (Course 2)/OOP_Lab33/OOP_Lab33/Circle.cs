using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab33
{
    class Circle : Shape
    {
        float radius;

        public float Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Circle() : base()
        {
            this.X = 0;
            this.Y = 0;
            radius = 0;
            this.Area = 0;
        }
        public Circle(int x, int y, float radius) : base(x, y)
        {
            this.radius = radius;
            this.Area = pi * radius * radius;
        }
        public override void changeRadius(float dRadius)
        {
            Radius += dRadius;
        }
    };
}
