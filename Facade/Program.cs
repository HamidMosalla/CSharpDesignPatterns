using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Facade_pattern
             What problems can the Facade design pattern solve?

                To make a complex subsystem easier to use,
                a simple interface should be provided for a set of interfaces in the subsystem.
                The dependencies on a subsystem should be minimized.

            Clients that access a complex subsystem directly refer to (depend on) many different objects
            having different interfaces (tight coupling),
            which makes the clients hard to implement, change, test, and reuse.
                         */

            var facade = new CarFacade.CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
