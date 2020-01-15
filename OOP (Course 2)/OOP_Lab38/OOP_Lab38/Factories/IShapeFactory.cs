using System;
using OOP_Lab38;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab38.Factories
{
    interface IShapeFactory
    {
        Shape createShape(string shapeName, int x = 0, int y = 0, int width = 1, int height = 1);
    }
}
