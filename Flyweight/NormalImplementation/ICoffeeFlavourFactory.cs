using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.NormalImplementation
{
    public interface ICoffeeFlavourFactory
    {
        CoffeeFlavour GetFlavour(string flavour);
    }
}
