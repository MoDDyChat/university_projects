using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab34
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Storage<Shape> shapes;

        public Form()
        {
            InitializeComponent();
            shapes = new Storage<Shape>();
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            var graphic = e.Graphics;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
                shapes.Current().Paint(graphic);
        }

        private void PaintPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!SelectShape(e.X - 50, e.Y - 50))
                    shapes.AddFirst(new Circle(e.X - 50, e.Y - 50, 100));
                paintPanel.Refresh();
            }
        }

        private bool SelectShape(int x, int y)
        {
            Shape shape;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                shape = shapes.Current();
                if (Math.Pow(x - shape.x, 2) + Math.Pow(y - shape.y, 2) <= 2500)
                {
                    if (shape.isSelected)
                    {
                        shape.isSelected = false;
                        shapes.Remove();
                        shapes.AddFirst(shape);
                    }
                    else
                    {
                        shape.isSelected = true;
                        shapes.Remove();
                        shapes.AddLast(shape);
                    }
                    paintPanel.Refresh();
                    return true;
                }
            }
            return false;
        }

        private void deleteSelectedShapes()
        {
            for(shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                if (shapes.Current().isSelected == true)
                {
                    shapes.Remove();
                    shapes.Prev();
                }
            }
            paintPanel.Refresh();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteSelectedShapes();
            }
        }
    }
}
