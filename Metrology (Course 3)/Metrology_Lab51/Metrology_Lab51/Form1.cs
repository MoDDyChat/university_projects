using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrology_Lab51
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        double randNum()
        {
            return Math.Round(rand.NextDouble(), 2);
        }

        double medFind(List<TextBox> list)
        {
            double med = 0;
            foreach (TextBox box in list)
            {
                med += Convert.ToDouble(box.Text);
            }
            return Math.Round(med / list.Count(), 2);
        }

        void allMedUpdate()
        {
            allBox1.Text = medFind(inList1).ToString();
            allBox2.Text = medFind(inList2).ToString();
            allBox3.Text = medFind(inList3).ToString();
            allBox4.Text = medFind(inList4).ToString();
            allBox5.Text = medFind(inList5).ToString();
            allBox6.Text = medFind(inList6).ToString();
            allBox7.Text = medFind(inList7).ToString();
            allBox8.Text = medFind(inList8).ToString();
            allBox9.Text = medFind(allList).ToString();
        }

        List<TextBox> inList1 = new List<TextBox>();
        List<TextBox> inList2 = new List<TextBox>();
        List<TextBox> inList3 = new List<TextBox>();
        List<TextBox> inList4 = new List<TextBox>();
        List<TextBox> inList5 = new List<TextBox>();
        List<TextBox> inList6 = new List<TextBox>();
        List<TextBox> inList7 = new List<TextBox>();
        List<TextBox> inList8 = new List<TextBox>();
        List<TextBox> allList = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();
            inBox1.Text = randNum().ToString();
            inBox2.Text = randNum().ToString();
            inBox3.Text = randNum().ToString();
            inBox4.Text = randNum().ToString();
            inBox5.Text = randNum().ToString();
            inBox6.Text = randNum().ToString();
            inBox7.Text = randNum().ToString();
            inBox8.Text = randNum().ToString();
            inBox9.Text = randNum().ToString();
            inBox10.Text = randNum().ToString();
            inBox11.Text = randNum().ToString();
            inBox12.Text = randNum().ToString();
            inBox13.Text = randNum().ToString();
            inBox14.Text = randNum().ToString();
            inBox15.Text = randNum().ToString();
            inBox16.Text = randNum().ToString();
            inBox17.Text = randNum().ToString();
            inBox18.Text = randNum().ToString();
            inBox19.Text = randNum().ToString();
            inBox20.Text = randNum().ToString();
            inBox21.Text = randNum().ToString();
            inBox22.Text = randNum().ToString();
            inBox23.Text = randNum().ToString();
            inBox24.Text = randNum().ToString();
            inBox25.Text = randNum().ToString();
            inBox26.Text = randNum().ToString();
            inBox27.Text = randNum().ToString();
            inBox28.Text = randNum().ToString();
            inBox29.Text = randNum().ToString();
            inBox30.Text = randNum().ToString();
            inBox31.Text = randNum().ToString();

            
            inList1.Add(inBox1);
            inList1.Add(inBox2);
            inList1.Add(inBox3);
            inList2.Add(inBox4);
            inList2.Add(inBox5);
            inList2.Add(inBox6);
            inList3.Add(inBox7);
            inList3.Add(inBox8);
            inList4.Add(inBox9);
            inList4.Add(inBox10);
            inList4.Add(inBox11);
            inList4.Add(inBox12);
            inList4.Add(inBox13);
            inList4.Add(inBox14);
            inList5.Add(inBox15);
            inList5.Add(inBox16);
            inList5.Add(inBox17);
            inList5.Add(inBox18);
            inList6.Add(inBox19);
            inList6.Add(inBox20);
            inList6.Add(inBox21);
            inList6.Add(inBox22);
            inList6.Add(inBox23);
            inList7.Add(inBox24);
            inList7.Add(inBox25);
            inList7.Add(inBox26);
            inList7.Add(inBox27);
            inList7.Add(inBox28);
            inList8.Add(inBox29);
            inList8.Add(inBox30);
            inList8.Add(inBox31);
            allList.Add(allBox1);
            allList.Add(allBox2);
            allList.Add(allBox3);
            allList.Add(allBox4);
            allList.Add(allBox5);
            allList.Add(allBox6);
            allList.Add(allBox7);
            allList.Add(allBox8);

            allMedUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allMedUpdate();
        }
    }
}
