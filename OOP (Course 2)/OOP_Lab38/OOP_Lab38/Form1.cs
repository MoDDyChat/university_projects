using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Lab38.Factories;

namespace OOP_Lab38
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Storage<Shape> shapes;
        private ShapeFactory factory;
        public int GWidth;
        public int GHeight;
        public int shapeType = 1;

        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PaintPanel, new object[] { true });

            shapes = new Storage<Shape>();
            factory = new ShapeFactory();

            GWidth = 100;
            GHeight = 100;

            sizeXBox.Text = GWidth.ToString();
            sizeYBox.Text = GHeight.ToString();
        }

        private bool SelectShape(int x, int y)
        {
            Shape shape;
            for (shapes.Last(); !shapes.isEnd(); shapes.Prev())
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
            CountLbl.Text = "Элементов: " + shapes.Count.ToString();
            PaintPanel.Refresh();
        }

        private void changeColorSelectedShapes()
        {
            colorSwitch.ShowDialog();
            var color = colorSwitch.Color;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                if (shapes.Current().isSelected == true)
                {
                    shapes.Current().changeColor(color);
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
                    shapes.Current().changeSize(GWidth, GHeight);
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
                        shapes.AddFirst(new Rectangle(e.X, e.Y - GHeight, GWidth, GHeight));
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
            Shape shape;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {
                shape = shapes.Current();
                if (shape.isSelected == true)
                {
                    shape.Move(dx, dy);
                    if (shape.borderCheck(bx, by, isUp))
                    {
                        shape.Move(-dx, -dy);
                    }
                }
            }
            PaintPanel.Refresh();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Up:
                    MoveShape(0, -5, -1, 0, true);
                    break;
                case Keys.Left:
                    MoveShape(-5, 0, 0, -1, true);
                    break;
                case Keys.Down:
                    MoveShape(0, 5, -1, PaintPanel.Size.Height, false);
                    break;
                case Keys.Right:
                    MoveShape(5, 0, PaintPanel.Size.Width, -1, false);
                    break;
                case Keys.A:
                    if (e.Control)
                        selectAll();
                    break;
                case Keys.D:
                    if (e.Control)
                        unSelectAll();
                    break;
                case Keys.Delete:
                    deleteSelectedShapes();
                    break;
            }
        }

        public void shapesToGroup()
        {
            GroupedShapes group = new GroupedShapes();
            for (shapes.First(); !shapes.isEnd();)
            {
                if(shapes.Current().isSelected)
                {
                    shapes.Current().Unselect();
                    group.Add(shapes.Current());
                    shapes.Remove(shapes.Current());
                }
                else
                {
                    shapes.Next();
                }
            }
            group.Select();
            shapes.AddLast(group);
            CountLbl.Text = "Элементов: " + shapes.Count.ToString();
            PaintPanel.Refresh();
        }

        public void LoadFigures(ShapeFactory sf)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    shapes.Clear();
                    var count = Convert.ToInt32(sr.ReadLine());
                    IShapeFactory factory = sf;
                    Shape shape;
                    for (int i = 0; i < count; i++)
                    {
                        var code = sr.ReadLine();
                        shape = factory.createShape(code);
                        shape.Load(sr, sf);
                        shapes.AddLast(shape);
                    }
                }
            }

        }

        public void SaveFigures()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(shapes.Count);
                    for (shapes.First(); !shapes.isEnd(); shapes.Next())
                        shapes.Current().Save(sw);
                }
            }
        }


        public void shapesUngroup()
        {
            for (shapes.First(); !shapes.isEnd();)
            {
                if (shapes.Current().isSelected && shapes.Current() is GroupedShapes)
                {
                    var groupElem = shapes.Current().getGroupElem();
                    shapes.Remove(shapes.Current());
                    for (groupElem.First(); !groupElem.isEnd(); groupElem.Next())
                    {
                        shapes.AddFirst(groupElem.Current());
                    }
                }
                else
                {
                    shapes.Next();
                }
            }
            CountLbl.Text = "Элементов: " + shapes.Count.ToString();
            PaintPanel.Refresh();
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

        private void ShapesToGroupBtn_Click(object sender, EventArgs e)
        {
            shapesToGroup();
        }

        private void UnGroupBtn_Click(object sender, EventArgs e)
        {
            shapesUngroup();
        }

        private void SaveToFileBtn_Click(object sender, EventArgs e)
        {
            SaveFigures();
        }

        private void LoadFormFileBtn_Click(object sender, EventArgs e)
        {
            LoadFigures(factory);
            PaintPanel.Refresh();
        }
    }
}
