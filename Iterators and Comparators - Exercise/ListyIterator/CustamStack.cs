using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class CustamStack<T> : IEnumerable<T>
    {
        private List<T> items;
        public CustamStack(List<T> items)
        {
            this.items = items;    
        }
        public void Push(T item)
        {
            items.Add(item);
        }
        public void Pop()
        {
            if (items.Count!=0)
            {
                items.RemoveAt(items.Count - 1);
            }
            else
            {
                throw new InvalidOperationException("No elements");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
