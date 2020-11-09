using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SiAKOD_RGR
{
    public partial class Form1 : Form
    {
        List<City> cities;
        List<Road> roads;

        int citiesNum = 0;
        float minValue = 9999999;
        City minValueCity;

        public Form1()
        {
            InitializeComponent();
            cities = new List<City>();
            roads = new List<Road>();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
               | BindingFlags.Instance | BindingFlags.NonPublic, null, paintBox, new object[] { true });
        }

        private void AddCity(int x, int y)
        {
            cities.Add(new City(x, y, 70, 70, (citiesNum++ + 1).ToString(), 999999, false, Color.LightGreen));
        }

        private void AddRoad()
        {
            var stack = new Stack<City>();

            foreach (var v in cities)
                if (v.Selected)
                    stack.Push(v);

            if (stack.Count >= 2)
            {
                var first = stack.Pop();
                var second = stack.Pop();

                if (!first.HasLink(second))
                {
                    roads.Add(new Road(first, second));
                    first.Deselect();
                    second.Deselect();
                }
            }
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            AddRoad();
            paintBox.Refresh();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cities.Count;)
            {
                if (cities[i].Selected)
                {
                    cities[i].RemoveLinks();
                    cities.RemoveAt(i);
                    if (cities.Count == 0)
                        citiesNum = 0;
                }
                else
                    i++;
            }

            for (int i = 0; i < roads.Count;)
            {
                if (roads[i].Selected || roads[i].isDeleted)
                {
                    roads[i].DeleteSelf();
                    roads.RemoveAt(i);
                }
                else
                    i++;
            }
            paintBox.Refresh();
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var road in roads)
                road.Paint(e.Graphics);

            foreach (var city in cities)
                city.Paint(e.Graphics);
        }

        private void DeselectBtn_Click(object sender, EventArgs e)
        {
            foreach (var city in cities)
                city.Deselect();
            paintBox.Refresh();
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var city in cities)
                if (city.isPointInFigure(e.X, e.Y))
                {
                    city.RevertSelection();
                    paintBox.Refresh();
                    return;
                }
            foreach (var road in roads)
                if (road.isPointInFigure(e.X, e.Y))
                {
                    road.RevertSelection();
                    paintBox.Refresh();
                    return;
                }

            AddCity(e.X, e.Y);
            paintBox.Refresh();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            DekstraAlgoritm dek = new DekstraAlgoritm(cities, roads, paintBox);
            textBox.Clear();
            textBox.Text = "Суммарное расстояние до других городов:" + Environment.NewLine;

            foreach (City city in cities)
                city.ValueSum = 0;

            foreach (City curCity in cities)
            {
                curCity.Color = Color.LightGoldenrodYellow;
                paintBox.Refresh();
                curCity.Value = 0;
                
                dek.startAlg(curCity);

                curCity.Color = Color.LightGreen;

                foreach (City city in cities)
                {
                    curCity.ValueSum += city.Value;
                    city.Value = 999999;
                    city.isChecked = false;
                }

                if (minValue > curCity.ValueSum)
                {
                    minValue = curCity.ValueSum;
                    minValueCity = curCity;
                }

                textBox.Text += "Город #" + curCity.Text + ": " + curCity.ValueSum + Environment.NewLine;
                System.Threading.Thread.Sleep(800);
            }
            minValueCity.Color = Color.Yellow;
            paintBox.Refresh();

        }
    }
}
