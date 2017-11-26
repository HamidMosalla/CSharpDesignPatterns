using Iterator.Aggregate;

namespace Iterator.Iterator
{
    internal class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _aggregate;

        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            return IsDone() ? null : _aggregate[++_current];
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count - 1;
        }
    }
}