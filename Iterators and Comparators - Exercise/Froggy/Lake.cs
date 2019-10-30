using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private List<T> elements;

        public Lake()
        {
            elements = new List<T>();
        }
        public void Add(T element)
        {
            this.elements.Add(element);
        }
        public void Add(List<T> elements)
        {
            this.elements.AddRange(elements);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return elements[i];
                }
            }
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return elements[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
