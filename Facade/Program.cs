using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //More info: https://en.wikipedia.org/wiki/Facade_pattern

            var facade = new CarFacade.CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}
