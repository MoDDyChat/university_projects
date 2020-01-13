using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab38
{
    class ShapeFactory : IShapeFactory
    {
        public Shape createShape(string shapeName, int x = 0, int y = 0, int width = 1, int height = 1)
        {
            Shape shape;
            switch(shapeName)
            {
                case "C":
                    shape = new Circle(x, y, width, height);
                    break;
                case "R":
                    shape = new Rectangle(x, y, width, height);
                    break;
                case "T":
                    shape = new Triangle(x, y, width, height);
                    break;
                case "G":
                    shape = new GroupedShapes();
                    break;
                default:
                    return null;
            }
            return shape;
        }
    }
}
