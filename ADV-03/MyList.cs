using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_03
{
    internal class MyList<T>
    {
        #region Part02
        public T[] Items { get; set; }
        public int Count { get; set; }
        public int Capacity { get; set; }


        public MyList()
        { }
        public MyList(int _capacity)
        {
            Capacity = _capacity;
            Items = new T[Capacity];
            Count = 0;
        }
        public void EnsureCapacity(int _capacity)
        {
            if (Items.Length < Capacity)
            {
                int newCapacity = Items.Length * 2;
                T[] newArray = new T[newCapacity];
                Array.Copy(Items, 0, newArray, 0, Count);
            }
        }

        public void Add(T value)
        {
            EnsureCapacity(Count + 1);
            Items[Count++] = value;
        }

        public bool Exist(Predicate<T> match)
        {
            foreach (T item in Items)
            {
                if (item != null && match(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in Items)
            {
                if (item != null && match(item))
                {
                    return item;
                }
            }
            return default;
        }

        public void Foreach(Action<T> action)
        {
            foreach (T item in Items)
            {
                if (item != null)
                {
                    action(item);
                }
            }
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < Count; i++)
            {
                if (match(Items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TrueForAll(Predicate<T> match)
        {
            foreach (var item in Items)
            {
                if (item != null && !match(item))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
