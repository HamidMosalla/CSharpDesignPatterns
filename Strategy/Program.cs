using System;
using System.Collections.Generic;
using Strategy.Anbstraction;
using Strategy.Implementations;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             More info: https://en.wikipedia.org/wiki/Strategy_pattern
             http://www.dofactory.com/net/strategy-design-pattern

            What problems can the Strategy design pattern solve? [3]

            A class should be configured with an algorithm instead of implementing an algorithm directly.
            An algorithm should be selected and exchanged at run-time.

            What is an algorithm? An algorithm is usually defined as a procedure that takes some value as input,
            performs a finite number of steps, and produces some value as output.
            From a more general point of view,
            an algorithm is a piece of code that does something appropriate.

            Implementing an algorithm directly within the class that uses the algorithm is inflexible because
            it commits the class to a particular algorithm at compile-time and makes it impossible to change
            the algorithm later independently from (without having to change) the class. This also stops the class
            from being reusable when another algorithm should be used.

                         */

            var dataReaders = new List<IDataReader> { new XmlDataReader(), new JsonDataReader(), new SqlDataReader() };

            //Our client doesn't care how data readers reads data, it only cares that there is a method called *ReadData* which it can call.
            foreach (var dataReader in dataReaders)
            {
                dataReader.ReadData();
            }
        }
    }
}
