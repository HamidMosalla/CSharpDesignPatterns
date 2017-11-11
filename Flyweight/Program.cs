using System;
using Flyweight.NormalImplementation;
using Flyweight.NormalImplementation.Clients;
using Flyweight.NormalImplementation.Minimal;
using Flyweight.SimpleImplementation;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * More info: https://en.wikipedia.org/wiki/Flyweight_pattern
             What problems can the Flyweight design pattern solve? [2]
               Large numbers of objects should be supported efficiently.
               Creating large numbers of objects should be avoided.

            When representing large text documents, for example, creating an object for each character in the document
            would result in a huge amount of objects that couldn't be processed efficiently.
            */

            var simpleClient = new ClientObject();
            //it'll share the same static FlyWeightPointer
            Console.WriteLine(simpleClient.Company);


            var flyWeightPointer = new ReducedMemoryFootprintFlavorFactory();
            var minimalflyWeightPointer = new MinimumMemoryFootprint();
            var coffeeMaker1 = new CoffeeMaker(flyWeightPointer);
            var coffeeMaker2 = new CoffeeMaker(flyWeightPointer);
            var coffeeMaker3 = new CoffeeMaker(flyWeightPointer);
            var coffeeMaker4 = new CoffeeMaker(flyWeightPointer);
            coffeeMaker1.MakeCoffee("Pepper?!");
            coffeeMaker2.MakeCoffee("Lemon?");
            coffeeMaker3.MakeCoffee("Chocolate");
            coffeeMaker4.MakeCoffee("Spider");
        }
    }
}
