using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab38
{
    class TreeViewObserver : TreeView, IObserver
    {
        public Storage<Shape> Shapes;

        public List<ISubject> subjects = new List<ISubject>();

        public TreeViewObserver() : base()
        {
            CheckBoxes = true;
        }

        public void OnSubjectChanged(ISubject subject, int dx, int dy)
        {
            this.Nodes.Clear();
            if (subject is Storage<Shape> shapes)
            {
                this.Shapes = shapes;
                FillNode(shapes, this.Nodes);
            }
        }

        public List<ISubject> getSubjects()
        {
            return subjects;
        }

        void FillNode(Storage<Shape> shapes, TreeNodeCollection nodes)
        {
            TreeNode node;
            int i = 0;
            for (shapes.First(); !shapes.isEnd(); shapes.Next())
            {

                string shapeName = "";
                if (shapes.Current().isSticky)
                    shapeName = "Sticky ";
                else if (shapes.Current().getSubjects().Count > 0)
                    shapeName = "Stuck ";
                if (shapes.Current() is Rectangle)
                    shapeName += "Rectangle";
                else if (shapes.Current() is Triangle)
                    shapeName += "Triangle";
                else if (shapes.Current() is Circle)
                    shapeName += "Circle";
                else
                    shapeName += "Group";

                node = nodes.Add(shapeName);
                node.Checked = shapes.Current().isSelected;

                if (shapes.Current() is GroupedShapes group)
                    FillNode(group.groupShapes, node.Nodes);
            }
        }

    }
}
