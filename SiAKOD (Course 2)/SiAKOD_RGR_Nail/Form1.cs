using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SiAKOD_RGR_Nail
{
    public partial class Form1 : Form
    {
        //Список всех вершин и узлов
        List<Vertex> vertexs;
        List<Edge> edges;

        //Для нумерования вершин
        int vertexsNum = 0;

        public Form1()
        {
            InitializeComponent();
            vertexs = new List<Vertex>();
            edges = new List<Edge>();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
               | BindingFlags.Instance | BindingFlags.NonPublic, null, paintBox, new object[] { true });
        }

        //Добавление вершины
        private void AddVertex(int x, int y)
        {
            if (x < paintBox.Width / 2)
                vertexs.Add(new Vertex(x, y, 40, 40, (vertexsNum++ + 1).ToString(), Color.LightBlue, true));
            else
                vertexs.Add(new Vertex(x, y, 40, 40, (vertexsNum++ + 1).ToString(), Color.LightGreen, false));
        }

        //Добавление узлов
        private void AddEdge()
        {
            var stack = new Stack<Vertex>();

            foreach (var v in vertexs)
                if (v.Selected)
                    stack.Push(v);

            if (stack.Count >= 2)
            {
                var first = stack.Pop();
                var second = stack.Pop();

                if (!first.HasLink(second))
                {
                    edges.Add(new Edge(first, second, Color.Black));
                    first.Deselect();
                    second.Deselect();
                }
            }
        }

        //Отрисовка панели
        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(pen, paintBox.Width / 2, 0, paintBox.Width / 2, paintBox.Height);
            foreach (var road in edges)
                road.Paint(e.Graphics);

            foreach (var city in vertexs)
                city.Paint(e.Graphics);
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var vertex in vertexs)
                if (vertex.isPointInFigure(e.X, e.Y))
                {
                    vertex.RevertSelection();
                    paintBox.Refresh();
                    return;
                }
            foreach (var edge in edges)
                if (edge.isPointInFigure(e.X, e.Y))
                {
                    edge.RevertSelection();
                    paintBox.Refresh();
                    return;
                }

            AddVertex(e.X, e.Y);
            paintBox.Refresh();
        }

        //Кнопка соединения
        private void MergeBtn_Click(object sender, EventArgs e)
        {
            AddEdge();
            paintBox.Refresh();
        }

        //Кнопка удаления
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vertexs.Count;)
            {
                if (vertexs[i].Selected)
                {
                    vertexs[i].RemoveLinks();
                    vertexs.RemoveAt(i);
                    if (vertexs.Count == 0)
                        vertexsNum = 0;
                }
                else
                    i++;
            }

            for (int i = 0; i < edges.Count;)
            {
                if (edges[i].Selected || edges[i].isDeleted)
                {
                    edges[i].DeleteSelf();
                    edges.RemoveAt(i);
                }
                else
                    i++;
            }
            paintBox.Refresh();
        }

        //Кнопка выполнения алгоритма
        private void FindBtn_Click(object sender, EventArgs e)
        {
            //Обнуление информации с предыдущего запуска алгоритма
            foreach(Vertex vert in vertexs)
            {
                vert.isChecked = false;
                vert.Link = null;
            }
            foreach (Edge edg in edges)
                edg.color = Color.Black;
            paintBox.Refresh();
            System.Threading.Thread.Sleep(500);

            //Запуск алгоритма Куна
            KuhnAlgorithm ka = new KuhnAlgorithm(vertexs, edges, paintBox);
            textBox.Text = "Размер максимального паросочетания равен: " + ka.Solve().ToString();
        }
    }
}
