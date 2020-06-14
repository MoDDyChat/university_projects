using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngGraph_Lab42
{
    public class Storage<T>
    {
        public class Node
        {
            public Node Next;
            public Node Prev;
            public T Value;

            public Node(T value)
            {
                Value = value;
            }
        }

        //Первый элемент
        private Node first;

        public void First()
        {
            current = first;
        }

        //Последний элемент
        private Node last;

        public void Last()
        {
            current = last;
        }

        //Данный элемент
        private Node current;

        public T Current()
        {
            if (!isEnd())
                return current.Value;
            else
                return default(T);
        }

        public T FirstNode()
        {
            return first.Value;
        }

        //Количество элементов в хранилище
        private int count = 0;
        public int Count { get => count; }

        //Проверка на конец
        public bool isEnd()
        {
            if (current == null)
            {
                return true;
            }
            return false;
        }

        //Переход к следующему элементу
        public void Next()
        {
            if (!isEnd())
                current = current.Next;
        }

        //Переход к предыдущему элементу
        public void Prev()
        {
            if (!isEnd())
                current = current.Prev;
        }

        //Добавить элемент с начала списка
        public void AddFirst(T item)
        {
            var newNode = new Node(item);
            if (count == 0)
            {
                current = newNode;
                last = newNode;
            }
            else
            {
                first.Prev = newNode;
                newNode.Next = first;
            }
            first = newNode;
            count++;
        }

        //Добавить элемент с конца списка
        public void AddLast(T item)
        {
            var newNode = new Node(item);
            if (count == 0)
            {
                first = newNode;
                current = newNode;
            }
            else
            {
                last.Next = newNode;
                newNode.Prev = last;
            }
            last = newNode;
            current = newNode;
            count++;
        }

        public void Remove()
        {
            if (!isEnd())
            {
                count--;
                if (count == 0)
                {
                    first = null;
                    last = null;
                    current = null;
                }
                else if (current == last)
                {
                    Prev();
                    current.Next = null;
                    last = current;
                }

                else if (current == first)
                {
                    Next();
                    current.Prev = null;
                    first = current;
                }
                else
                {
                    current.Next.Prev = current.Prev;
                    current.Prev.Next = current.Next;
                    Next();
                }
            }
        }

        public void Clear()
        {
            First();
            while (!isEnd())
                Remove();
        }

        public void Remove(T item)
        {
            for (First(); !isEnd(); Next())
            {
                if (Current().Equals(item))
                {
                    Remove();
                    return;
                }
            }
        }
    }
}
