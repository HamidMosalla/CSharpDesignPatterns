using System;
using AbstractFactory.Cars;
using AbstractFactory.Cars.ConcreteCars;
using AbstractFactory.Client;
using AbstractFactory.Factory;
using AbstractFactory.Factory.AnstractFactory;
using AbstractFactory.Factory.ConcreteFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             More info: https://en.wikipedia.org/wiki/Abstract_factory_pattern
             https://csharpdesignpatterns.codeplex.com/wikipage?title=Abstract%20Factory%20Pattern&referringTitle=Home
             The Abstract Factory design pattern solves problems like:

                How can an application be independent of how its objects are created?
                How can a class be independent of how the objects it requires are created?
                How can families of related or dependent objects be created?

            Creating objects directly within the class that requires the objects is inflexible because it commits
            the class to particular objects and makes it impossible to change the instantiation later independently
            from (without having to change) the class. It stops the class from being reusable if other objects are required,
            and it makes the class hard to test because real objects can't be replaced with mock objects.
             */


            CarFactory audiFactory = new AudiFactory();
            Driver driver1 = new Driver(audiFactory);
            driver1.CompareSpeed();

            CarFactory mercedesFactory = new MercedesFactory();
            Driver driver2 = new Driver(mercedesFactory);
            driver2.CompareSpeed();


            var factory = new GenericFactory<MercedesSportsCar>();
            var mercedesSportsCar = factory.CreateObject();
            Console.WriteLine(mercedesSportsCar.GetType().ToString());

            Console.ReadKey();
        }
    }
}
