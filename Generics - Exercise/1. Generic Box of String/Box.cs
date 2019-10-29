using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T>
        where T: IComparable
    {
        private T value;

        private List<T> values;
        public Box()
        {
            values = new List<T>();
        }
        public void Add(T item)
        {
            values.Add(item);
        }
        public void Swap(int a, int b)
        {
            var temp = values[a];
            values[a] = values[b];
            values[b] = temp;
        }
        public int CountOfLargerElements(T element)
        {
            int count = 0;

            foreach (var item in this.values)
            { 
                if (item.CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.values)
            {
                sb.AppendLine($"{item.GetType()}: {item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
