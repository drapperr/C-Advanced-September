using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Data_Structures
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        private int count;

        public int Count => count; // return Count

        public CustomList() // Create new CustomList
        {
            items = new int[InitialCapacity];
            count = 0;
        }

        public void Add(int element)
        {
            Resize(this.count);
            this.items[this.count] = element;
            this.count++;
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);
            var item = this.items[index];
            Shift(index);
            this.count--;
            Shrink();
            return item;
        }

        public void Insert(int index, int item)
        {
            ValidateIndex(index);
            Resize(this.count + 1);
            ShiftRight(index);
            this.items[index] = item;
        }

        public bool Contains(int element)
        {
            if (IndexOf(element) == -1)
            {
                return false;
            }

            return true;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            var temp = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }

        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++)
            {
                Swap(i, count - 1 - i);
            }
        }

        public int IndexOf(int item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (item == items[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i] + ", ");
            }

            return sb.ToString().TrimEnd(' ', ',');
        }

        private void ShiftRight(int index)
        {
            for (int i = count - 1; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= this.count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        } //indexer

        private void Resize(int count) // this method will be used to increase the internal collection's length twice
        {
            if (this.count == this.items.Length)
            {
                var copy = new int[this.items.Length * 2];

                for (int i = 0; i < count; i++)
                {
                    copy[i] = this.items[i];
                }

                this.items = copy;
            }
        }

        private void Shrink() //this method will help us to decrease the internal collection's length twice 
        {
            if (this.count * 4 == items.Length)
            {
                var copyItems = new int[items.Length / 2];

                for (int i = 0; i < this.count; i++)
                {
                    copyItems[i] = this.items[i];
                }

                this.items = copyItems;
            }
        }

        private void Shift(int index) //this method will help us to rearrange the internal collection's elements after removing one
        {
            for (int i = index; i < this.count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }
    }
}
