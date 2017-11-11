using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.NormalImplementation.Clients
{
    public class CoffeeMaker
    {
        private ReducedMemoryFootprintFlavorFactory _flavourFactory;

        public CoffeeMaker(ReducedMemoryFootprintFlavorFactory flavourFactory)
        {
            _flavourFactory = flavourFactory;
        }

        public void MakeCoffee(string flavour)
        {
            Console.WriteLine($"Making coffee with {_flavourFactory.GetFlavour(flavour).Flavour} flavor.");
        }
    }
}
