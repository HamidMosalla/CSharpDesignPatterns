using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flyweight.NormalImplementation
{
    public class ReducedMemoryFootprintFlavorFactory : ICoffeeFlavourFactory
    {
        private readonly object _cacheLock = new object();
        private readonly IDictionary<string, CoffeeFlavour> _cache = new Dictionary<string, CoffeeFlavour>();

        public CoffeeFlavour GetFlavour(string flavour)
        {
            if (_cache.ContainsKey(flavour)) return _cache[flavour];
            var coffeeFlavour = new CoffeeFlavour(flavour);
            ThreadPool.QueueUserWorkItem(AddFlavourToCache, coffeeFlavour);
            return coffeeFlavour;
        }

        private void AddFlavourToCache(object state)
        {
            var coffeeFlavour = (CoffeeFlavour)state;
            if (!_cache.ContainsKey(coffeeFlavour.Flavour))
            {
                lock (_cacheLock)
                {
                    if (!_cache.ContainsKey(coffeeFlavour.Flavour)) _cache.Add(coffeeFlavour.Flavour, coffeeFlavour);
                }
            }
        }
    }
}
