using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using OOP_Lab38.Factories;

namespace OOP_Lab38
{
    public abstract class Shape : ISubject, IObserver
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public bool isSelected;
        public Color color = Color.Yellow;

        public void Unselect()
        {
            isSelected = false;
        }

        public void Select()
        {
            isSelected = true;
        }

        public abstract void Paint(Graphics graphic);

        public abstract bool lookAtShape(int x, int y);

        public abstract bool borderCheck(int borderX, int borderY, bool isUp);

        public virtual void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public virtual void selectiveInvert()
        {
            if (isSelected == true)
                isSelected = false;
            else
                isSelected = true;
        }

        public virtual void Load(StreamReader sr, ShapeFactory sf)
        {
            x = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            y = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            width = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            height = Convert.ToInt32(sr.ReadLine().Split('=')[1]);
            color = Color.FromArgb(Convert.ToInt32(sr.ReadLine().Split('=')[1]));
            
        }
        public virtual void Save(StreamWriter sw)
        {
            sw.WriteLine($"x={x}");
            sw.WriteLine($"y={y}");
            sw.WriteLine($"width={width}");
            sw.WriteLine($"height={height}");
            sw.WriteLine($"color={color.ToArgb()}");
        }

        public virtual void changeSize(int x, int y)
        {
            width = x;
            height = y;
        }

        public virtual void changeColor(Color _color)
        {
            color = _color;
        }

        public virtual Storage<Shape> getGroupElem()
        {
            return null;
        }

        List<IObserver> observers = new List<IObserver>();
        List<ISubject> subjects = new List<ISubject>();

        public void addObserver(IObserver _observer)
        {
            observers.Add(_observer);
            _observer.getSubjects().Add(this);
        }

        public void removeObserver(IObserver _observer)
        {
            observers.Remove(_observer);
            _observer.getSubjects().Remove(this);
        }

        public void notifyAll()
        {
            foreach (var ob in observers)
            {
                ob.OnSubjectChanged(this);
            }
        }

        public List<IObserver> getObservers()
        {
            return observers;
        }

        public void OnSubjectChanged(ISubject subject)
        {
            throw new NotImplementedException();
        }

        public List<ISubject> getSubjects()
        {
            return subjects;
        }
    }
}
