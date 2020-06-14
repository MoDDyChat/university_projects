﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public Color color;

        public abstract void Paint(Graphics graphic);
    }
}
