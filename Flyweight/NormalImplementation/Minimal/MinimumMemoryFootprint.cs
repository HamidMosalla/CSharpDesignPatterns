using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.NormalImplementation.Minimal
{
    public class MinimumMemoryFootprint : ICoffeeFlavourFactory
    {
        private readonly ConcurrentDictionary<string, CoffeeFlavour> _cache = new ConcurrentDictionary<string, CoffeeFlavour>();

        public CoffeeFlavour GetFlavour(string flavour)
        {
            return _cache.GetOrAdd(flavour, flv => new CoffeeFlavour(flv));
        }
    }
}
