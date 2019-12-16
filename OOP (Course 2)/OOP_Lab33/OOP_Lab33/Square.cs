using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab33
{
    class Square : Shape
    {
        float length;

        public float Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public Square() : base()
        {
            this.X = 0;
            this.Y = 0;
            this.Area = 0;
        }
        public Square(int x, int y, float length) : base(x, y)
        {
            this.length = length;
            this.Area = Length * Length;
        }

        public override void changeLength(float dLength)
        {
            Length += dLength;
        }
    };
}
