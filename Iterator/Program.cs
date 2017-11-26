using System;
using Iterator.Aggregate;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * More info: https://en.wikipedia.org/wiki/Iterator_pattern
             * http://www.dofactory.com/net/iterator-design-pattern
         What problems can the Iterator design pattern solve?
            The elements of an aggregate object should be accessed and traversed without exposing its representation (data structures).
            New traversal operations should be defined for an aggregate object without changing its interface.

            Defining access and traversal operations in the aggregate interface is inflexible
            because it commits the aggregate to particular access and traversal operations
            and makes it impossible to add new operations later without having to change the aggregate interface.
           */

            var a = new ConcreteAggregate
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            Iterator.Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
    }
}
