using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        public int Count => items.Count;
        public void Add(T element)
        {
            items.Add(element);
        }
        public T Remove()
        {
            T element = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return element;
        }
    }
}
