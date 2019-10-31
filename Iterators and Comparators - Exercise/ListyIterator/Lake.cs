using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class Lake : IEnumerable<int>
    {
        private List<int> elements;

        public Lake()
        {
            elements = new List<int>();
        }
        public void Add(int element)
        {
            this.elements.Add(element);
        }
        public void Add(List<int> elements)
        {
            this.elements.AddRange(elements);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (i%2!=0)
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
