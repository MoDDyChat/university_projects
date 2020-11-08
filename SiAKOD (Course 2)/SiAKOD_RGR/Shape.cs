using System.Drawing;

namespace SiAKOD_RGR
{
    public abstract class Shape
    {
        public bool Selected;


        public void Select()
        {
            Selected = true;
        }
        public void Deselect()
        {
            Selected = false;
        }

        public void RevertSelection()
        {
            Selected = !Selected;
        }

        public abstract void Paint(Graphics g);
        public abstract bool isPointInFigure(int x, int y);

    }
}
