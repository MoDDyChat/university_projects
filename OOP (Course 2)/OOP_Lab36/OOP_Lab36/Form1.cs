using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab36
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Storage<Shape> shapes;
        public int GWidth;
        public int GHeight;
        public int shapeType = 1;

        public Form1()
        {
            InitializeComponent();

            shapes = new Storage<Shape>();

            GWidth = 100;
            GHeight = 100;

            sizeXBox.Text = GWidth.ToString();
            sizeYBox.Text = GHeight.ToString();
            
        }

        private bool SelectShape(int x, int y)
        {
            Shape shape;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                shape = shapes.Current();
                if (shape.lookAtShape(x, y))
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
                    PaintPanel.Refresh();
                    return true;
                }
            }
            return false;
        }

        private void deleteSelectedShapes()
        {
            shapes.First();
            while(!shapes.isEnd())
            {
                if (shapes.Current().isSelected == true)
                    shapes.Remove();
                else
                    shapes.Next();
            }
            PaintPanel.Refresh();
        }

        private void changeColorSelectedShapes()
        {
            colorSwitch.ShowDialog();
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                if (shapes.Current().isSelected == true)
                {
                    shapes.Current().color = colorSwitch.Color;
                }
            }
            PaintPanel.Refresh();
        }

        private void changeSizeSelectedShapes()
        {
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                if (shapes.Current().isSelected == true)
                {
                    shapes.Current().width = GWidth;
                    shapes.Current().height = GHeight;
                }
            }
            PaintPanel.Refresh();
        }

        private void selectAll()
        {
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                shapes.Current().isSelected = true;
            }
            PaintPanel.Refresh();
        }

        private void unSelectAll()
        {
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                shapes.Current().isSelected = false;
            }
            PaintPanel.Refresh();
        }


        private void PaintPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!SelectShape(e.X, e.Y))
                {
                    if (shapeType == 1)
                        shapes.AddFirst(new Circle(e.X - GWidth / 2, e.Y - GHeight / 2, GWidth, GHeight));
                    else if (shapeType == 2)
                        shapes.AddFirst(new Rectangle(e.X, e.Y, GWidth, GHeight));
                    else if (shapeType == 3)
                        shapes.AddFirst(new Triangle(e.X, e.Y, GWidth, GHeight));
                }
                CountLbl.Text = "Элементов: " + shapes.Count.ToString();
                PaintPanel.Refresh();
            }
        }

        private void PaintPanel_Paint(object sender, PaintEventArgs e)
        {
            var graphic = e.Graphics;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
                shapes.Current().Paint(graphic);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteSelectedShapes();
            CountLbl.Text = "Элементов: " + shapes.Count.ToString();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            changeColorSelectedShapes();
        }

        private void SizeXBox_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(sizeXBox.Text, out GWidth))
                changeSizeSelectedShapes();
        }

        private void SizeYBox_TextChanged(object sender, EventArgs e)
        {
            if(Int32.TryParse(sizeYBox.Text, out GHeight))
            changeSizeSelectedShapes();
        }

        private void ChangeSizeButton_Click(object sender, EventArgs e)
        {
            changeSizeSelectedShapes();
        }

        private void MoveShape(int dx, int dy, int bx, int by, bool isUp)
        {
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                if (shapes.Current().isSelected == true && !shapes.Current().borderCheck(bx, by, isUp))
                {
                    shapes.Current().x += dx;
                    shapes.Current().y += dy;
                }
            }
            PaintPanel.Refresh();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    MoveShape(0, -2, -1, 0, true);
                    break;
                case Keys.A:
                    MoveShape(-2, 0, 0, -1, true);
                    break;
                case Keys.S:
                    MoveShape(0, 2, -1, PaintPanel.Size.Height, false);
                    break;
                case Keys.D:
                    MoveShape(2, 0, PaintPanel.Size.Width, -1, false);
                    break;
            }
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            shapeType = 1;
            typeLbl.Text = "Выбрано: Круг";
        }

        private void RectButton_Click(object sender, EventArgs e)
        {
            shapeType = 2;
            typeLbl.Text = "Выбрано: Прямоугольник";
        }

        private void TriButton_Click(object sender, EventArgs e)
        {
            shapeType = 3;
            typeLbl.Text = "Выбрано: Треугольник";
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void UnSelectAllButton_Click(object sender, EventArgs e)
        {
            unSelectAll();
        }

        private void PaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            testLbl.Text = PaintPanel.Size.ToString() + " | " + e.Location.ToString();
        }
    }
}
