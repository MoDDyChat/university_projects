using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab34
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public bool isSelected;

        public abstract void Paint(Graphics graphic);
    }
}
