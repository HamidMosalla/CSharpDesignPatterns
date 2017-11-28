using System;
using System.Collections.Generic;
using Prototype.AbstractPrototype;
using Prototype.ConcretePrototype;

namespace Prototype.PrototypeUsage
{
    class Factory
    {
        private static readonly Dictionary<string, IPerson> Prototypes = new Dictionary<string, IPerson>();

        static Factory()
        {
            Prototypes.Add("tom", new Tom());
            Prototypes.Add("dick", new Dick());
            Prototypes.Add("harry", new Harry());
        }

        public static IPerson GetPrototype(string type)
        {
            try
            {
                return Prototypes.GetValueOrDefault(type).Clone();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Prototype with name: " + type + ", doesn't exist");
                return null;
            }
        }
    }
}