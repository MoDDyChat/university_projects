using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngGraph_Lab43
{
    public partial class Form1 : Form
    {
        int currentMod = 0;
        Example1 ex1;
        Example2 ex2;
        Example3 ex3;
        Example4 ex4;
        Double factor = Math.PI / 180;
        double factX = 0;
        double factY = 0;
        double factZ = 0;
        int scrollAxis = 0;
        bool isFill = false;

        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, paintBox, new object[] { true });

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ex1 = new Example1();
            currentMod = 1;
            paintBox.Refresh();
            checkBox1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ex2 = new Example2();
            currentMod = 2;
            paintBox.Refresh();
            checkBox1.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ex3 = new Example3();
            ex3.FillSide();
            currentMod = 3;
            paintBox.Refresh();
            checkBox1.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ex4 = new Example4();
            ex4.FillSide();
            currentMod = 4;
            paintBox.Refresh();
            checkBox1.Enabled = true;
        }

        private void PitchBar_Scroll(object sender, EventArgs e)
        {
            factX = factor * PitchBar.Value;
            scrollAxis = 0;
            paintBox.Refresh();
        }

        private void YawBar_Scroll(object sender, EventArgs e)
        {
            factY = factor * YawBar.Value;
            scrollAxis = 1;
            paintBox.Refresh();
        }

        private void RollBar_Scroll(object sender, EventArgs e)
        {
            factZ = factor * RollBar.Value;
            scrollAxis = 2;
            paintBox.Refresh();
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (currentMod == 1)
            {
                ex1.DrawShape(graphics, scrollAxis, factX, factY, factZ);
            }
            if (currentMod == 2)
            {
                ex2.DrawShape(graphics, factX, factY, factZ);
            }
            if (currentMod == 3)
            {
                ex3.DrawShape(graphics, factX, factY, factZ, paintBox.Width, paintBox.Height, isFill);
            }
            if (currentMod == 4)
            {
                ex4.DrawShape(graphics, factX, factY, factZ, paintBox.Width, paintBox.Height, isFill);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            isFill = checkBox1.Checked;
            paintBox.Refresh();
        }
    }
}
