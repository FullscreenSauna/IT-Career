using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Implementing_ArrayList
{
    class MyArrayList<T>
    {
        private int capacity;
        private T[] items;

        public int Count { get; private set; }
        public int Capacity { get => capacity; private set => capacity = value; }

        public MyArrayList()
        {
            Capacity = 2;
            items = new T[Capacity];
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return this.items[index];
            }

            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            }
        }

        private void ValidateIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Check your indexes");
            }
        }

        private void Grow()
        {
            if (Count >= capacity)
            {
                capacity *= 2;

                T[] copy = new T[capacity];

                for (int i = 0; i < items.Length; i++)
                {
                    copy[i] = items[i];
                }

                items = copy;
            }
        }

        public void Add(T item)
        {
            Grow();

            items[Count] = item;
            Count++;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            items[index] = default(T);

            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            Count--;
        }
    }
}
