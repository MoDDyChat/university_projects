using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class ImageBrush : Shape
    {
        Image texture;

        public ImageBrush(int x, int y)
        {
            texture = Image.FromFile(@"resources\texture\cobblestone.jpg");
            this.x = x;
            this.y = y;
        }

        public override void Paint(Graphics graphics)
        {
            TextureBrush tBrush = new TextureBrush(texture);
            Pen tPen = new Pen(tBrush, 2);
            //graphics.DrawImage(texture, x, y, texture.Width, texture.Height);
            graphics.FillEllipse(tBrush, x, y, 60, 60);
        }
            
    }
}
