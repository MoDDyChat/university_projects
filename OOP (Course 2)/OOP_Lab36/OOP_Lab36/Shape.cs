using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab36
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public bool isSelected;
        public Color color = Color.Yellow;

        public abstract void Paint(Graphics graphic);

        public abstract bool lookAtShape(int x, int y);

        public abstract bool borderCheck(int borderX, int borderY, bool isUp);
    }
}
