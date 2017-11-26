using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.BuiltIn
{
    public class MyCollection<T> : IEnumerable<T>
    {
        public T[] Items = new T[4];
        public int CountIndex;

        public T this[int index]
        {
            get { return Items[index]; }
            set { Items[index] = value; }
        }

        public void Add(T item)
        {
            if(Items.Length == CountIndex) Array.Resize(ref Items, Items.Length * 2);

            Items[CountIndex++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyCollectionEnumerator<T>(this);

            /*
             //or simply:
             for (int i = 0; i < _countIndex; i++) yield return _items[i];
            */
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
