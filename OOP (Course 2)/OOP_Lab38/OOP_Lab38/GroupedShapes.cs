using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab38
{
    class GroupedShapes : Shape
    {
        public Storage<Shape> groupShapes;

        public GroupedShapes()
        {
            groupShapes = new Storage<Shape>();
        }

        public void Add(Shape shape) {
            groupShapes.AddLast(shape);
            setSize();
        }

        public void Remove(Shape shape)
        {
            groupShapes.Remove(shape);
        }

        public override void Load(StreamReader sr)
        {
            groupShapes.Clear();
            var count = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            IShapeFactory factory = new ShapeFactory();
            Shape shape;
            for (int i = 0; i < count; i++)
            {
                var code = sr.ReadLine();
                shape = factory.createShape(code);
                shape.Load(sr);
                Add(shape);
            }
        }

        public override void Save(StreamWriter sw)
        {
            sw.WriteLine("G");
            sw.WriteLine($"count={groupShapes.Count}");
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                groupShapes.Current().Save(sw);
            }
        }

        public override Storage<Shape> getGroupElem()
        {
            Storage<Shape> tempStorage = new Storage<Shape>();
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                tempStorage.AddLast(groupShapes.Current());
            }
            return tempStorage;
        }

        public override void Paint(Graphics g)
        {
            for(groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                groupShapes.Current().Paint(g);
            }
            if (isSelected)
                g.DrawRectangle(new Pen(Color.Gray, 1), x, y, width, height);
        }

        public override void Move(int dx, int dy)
        {
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                groupShapes.Current().Move(dx, dy);
            }
            x += dx;
            y += dy;
        }

        public override void changeSize(int x, int y)
        {
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                groupShapes.Current().changeSize(x, y);
            }
            setSize();
        }

        public override void changeColor(Color _color)
        {
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                groupShapes.Current().changeColor(_color);
            }
        }

        public override bool lookAtShape(int x, int y)
        {
            for(groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                if (groupShapes.Current().lookAtShape(x, y))
                    return true;
            }
            return false;
        }

        void setSize()
        {
            int left = Int32.MaxValue, right = 0, up = Int32.MaxValue, down = 0;
            Shape shape = groupShapes.Current();
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                shape = groupShapes.Current();

                if (left > shape.x)
                    left = shape.x;
                if (right < shape.x + shape.width)
                    right = shape.x + shape.width;
                if (up > shape.y)
                    up = shape.y;
                if (down < shape.y + shape.height)
                    down = shape.y + shape.height;
            }

            width = right - left;
            height = down - up;
            x = left;
            y = up;
        }

        public override bool borderCheck(int borderX, int borderY, bool isUp)
        {
            for (groupShapes.First(); !groupShapes.isEnd(); groupShapes.Next())
            {
                if (groupShapes.Current().borderCheck(borderX, borderY, isUp))
                    return true;
            }
            return false;
        }
    }
}
