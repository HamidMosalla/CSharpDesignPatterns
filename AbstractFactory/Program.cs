using System;
using AbstractFactory.Cars;
using AbstractFactory.Cars.ConcreteCars;
using AbstractFactory.Client;
using AbstractFactory.Factory;
using AbstractFactory.Factory.ConcreteFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
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
