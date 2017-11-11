using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.NormalImplementation
{
    public class CoffeeFlavour
    {
        private readonly string _flavour;

        public CoffeeFlavour(string flavour)
        {
            _flavour = flavour;
        }

        public string Flavour
        {
            get { return _flavour; }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is CoffeeFlavour && Equals((CoffeeFlavour)obj);
        }

        public bool Equals(CoffeeFlavour other)
        {
            return string.Equals(_flavour, other._flavour);
        }

        public override int GetHashCode()
        {
            return (_flavour != null ? _flavour.GetHashCode() : 0);
        }

        public static bool operator ==(CoffeeFlavour a, CoffeeFlavour b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(CoffeeFlavour a, CoffeeFlavour b)
        {
            return !Equals(a, b);
        }
    }
}
