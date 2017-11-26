using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.BuiltIn
{
    class MyCollectionEnumerator<T> : IEnumerator<T>
    {
        private int index = -1;
        private MyCollection<T> _myCollection;

        public MyCollectionEnumerator(MyCollection<T> myCollection)
        {
            _myCollection = myCollection;
        }

        public bool MoveNext()
        {
            return ++index < _myCollection.CountIndex;
        }

        public T Current
        {
            get
            {
                if (index < 0 || _myCollection.CountIndex <= index) return default(T);

                return _myCollection.Items[index];
            }
        }

        object IEnumerator.Current => Current;






        public void Dispose() { }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}
