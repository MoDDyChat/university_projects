using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngGraph_Lab42
{
    class myImage
    {
        int x;
        int y;
        int Width;
        int Height;
        Image img;
        Panel sender;
        GraphicsPath myPath;
        Bitmap bMap;
        Bitmap tempBMap;
        int Red, Green, Blue;

        public myImage(int x, int y, Image img, Panel sender)
        {
            this.x = x;
            this.y = y;
            this.Height = img.Height;
            this.Width = img.Width;
            this.img = img;
            this.sender = sender;
            this.bMap = new Bitmap(img);
            this.tempBMap = new Bitmap(img);

        }

        public void Paint(Graphics graphic)
        {
            if (myPath != null)
            {
                graphic.SetClip(myPath);
            }
            graphic.DrawImage(bMap, new Point(x, y));    
        }

        public void Clip(List<Point> points)
        {
            myPath = new GraphicsPath();
            myPath.AddPolygon(points.ToArray());
        }

        public void InvertColor()
        {
            for (int i = 1; i < this.Height - 2; i++)
            {
                for (int j = 1; j < this.Width - 2; j++)
                {
                    Red = 255 - tempBMap.GetPixel(j - 1, i - 1).R;
                    Green = 255 - tempBMap.GetPixel(j - 1, i - 1).G;
                    Blue = 255 - tempBMap.GetPixel(j - 1, i - 1).B;

                    Red = Math.Min(Math.Max(Red, 0), 255);
                    Blue = Math.Min(Math.Max(Blue, 0), 255);
                    Green = Math.Min(Math.Max(Green, 0), 255);

                    bMap.SetPixel(j, i, Color.FromArgb(Red, Green, Blue));
                }
            }
        }
    }
}
