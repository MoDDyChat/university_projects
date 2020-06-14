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

namespace EngGraph_Lab42
{
    public partial class Form1 : Form
    {
        public Storage<Shape> shapes;
        public int currentMod = 0;
        public int clickNum = 0;
        Color color = Color.Red;
        List<Point> points = new List<Point>();
        myImage CurrentImage;

        public Form1()
        {
            InitializeComponent();
            shapes = new Storage<Shape>();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, paintBox, new object[] { true });
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
                shapes.Current().Paint(graphic);
            if (CurrentImage != null)
                CurrentImage.Paint(graphic);
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            currentMod = 1;
            clickNum = 0;
            points.Clear();
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentMod == 1)
            {
                if (clickNum == 0)
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum = 1;
                }
                else
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum = 0;
                    shapes.AddLast(new Line(points[0], points[1], color));
                    paintBox.Refresh();
                    points.Clear();
                }
            }
            else if (currentMod == 2)
            {
                shapes.AddLast(new Circle(e.X - 75, e.Y - 100, 150, 200, color));
                paintBox.Refresh();
            }
            else if (currentMod == 3)
            {
                if (clickNum == 3)
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum = 0;
                    shapes.AddLast(new Bezier(points, color));
                    paintBox.Refresh();
                    points.Clear();
                }
                else
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum++;
                }
            }
            else if (currentMod == 4)
            {
                shapes.AddLast(new Pie(e.X - 100, e.Y - 50, 200, 100, 0f, 90f, color));
                paintBox.Refresh();
            }
            else if (currentMod == 5)
            {
                if (clickNum == 7)
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum = 0;
                    shapes.AddLast(new GraphicPath(points));
                    paintBox.Refresh();
                    points.Clear();
                }
                else
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum++;
                }
            }
            else if (currentMod == 6)
            {
                if (shapes.Current() is ColorInter)
                    shapes.Remove();
                shapes.AddLast(new ColorInter(e.X, e.Y));
                paintBox.Refresh();
            }
            else if (currentMod == 7)
            {
                shapes.AddLast(new ImageBrush(e.X - 30, e.Y - 30));
                paintBox.Refresh();
            }
            else if (currentMod == 8)
            {
                shapes.AddLast(new SubShape(e.X - 30, e.Y - 30, color));
                paintBox.Refresh();
            }
            else if (currentMod == 9)
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "@";
                fileDialog.Filter = "Images|*.GIF;*JPG;*.TIF;*BMP";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream myStream = fileDialog.OpenFile();
                    if (!(myStream is null))
                    {
                        CurrentImage = new myImage(e.X, e.Y, Image.FromFile(fileDialog.FileName), this.paintBox);
                        paintBox.Refresh();
                    }
                }
            }
            else if (currentMod == 10)
            {
                if (clickNum == 3)
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum = 0;
                    CurrentImage.Clip(points);
                    paintBox.Refresh();
                    points.Clear();
                }
                else
                {
                    points.Add(new Point(e.X, e.Y));
                    clickNum++;
                }
            }
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentMod == 1 && clickNum == 1)
            {
                shapes.Last();
                if (shapes.Current() is Line)
                    shapes.Remove();
                points.Insert(1, new Point(e.X, e.Y));
                shapes.AddLast(new Line(points[0], points[1], color));
                paintBox.Refresh();
            }
        }

        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            colorSwitch.ShowDialog();
            color = colorSwitch.Color;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            currentMod = 2;
            clickNum = 0;
            points.Clear();
        }

        private void BezierBtn_Click(object sender, EventArgs e)
        {
            currentMod = 3;
            clickNum = 0;
            points.Clear();
        }

        private void PieBtn_Click(object sender, EventArgs e)
        {
            currentMod = 4;
            clickNum = 0;
            points.Clear();
        }

        private void GraphicPathBtn_Click(object sender, EventArgs e)
        {
            currentMod = 5;
            clickNum = 0;
            points.Clear();
        }

        private void ColorIntBtn_Click(object sender, EventArgs e)
        {
            currentMod = 6;
            clickNum = 0;
            points.Clear();
        }

        private void TextureBrushBtn_Click(object sender, EventArgs e)
        {
            currentMod = 7;
            clickNum = 0;
            points.Clear();
        }

        private void XorShape_Click(object sender, EventArgs e)
        {
            currentMod = 8;
            clickNum = 0;
            points.Clear();
        }

        private void PasteImgBtn_Click(object sender, EventArgs e)
        {
            currentMod = 9;
            clickNum = 0;
            points.Clear();
        }

        private void ClipImgBtn_Click(object sender, EventArgs e)
        {
            currentMod = 10;
            clickNum = 0;
            points.Clear();
        }

        private void InvertColorBtn_Click(object sender, EventArgs e)
        {
            CurrentImage.InvertColor();
            paintBox.Refresh();
        }
    }
}
