using System.Collections;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    internal class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public int Count => _items.Count;

        public object this[int index]
        {
            get => _items[index];

            set => _items.Insert(index, value);
        }

        public override Iterator.Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
