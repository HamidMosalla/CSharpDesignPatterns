using System;
using Prototype.AbstractPrototype;
using Prototype.PrototypeUsage;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * More info: https://sourcemaking.com/design_patterns/prototype
             The Prototype design pattern solves problems like:

                Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
                Co-opt one instance of a class for use as a breeder of all future instances.
                The new operator considered harmful.

            More info: https://en.wikipedia.org/wiki/Prototype_pattern
            This pattern is used to:

                avoid subclasses of an object creator in the client application, like the factory method pattern does.
                avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword)
                when it is prohibitively expensive for a given application.
             */

            var people = new[] { "tom", "dick", "harry" };

            foreach (var item in people)
            {
                IPerson prototype = Factory.GetPrototype(item);

                Console.WriteLine(item);
            }

            Console.WriteLine(Factory.GetPrototype("tom"));
        }
    }
}
