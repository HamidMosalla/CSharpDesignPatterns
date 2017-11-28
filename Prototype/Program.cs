using System;
using Prototype.AbstractPrototype;
using Prototype.PrototypeUsage;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
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
