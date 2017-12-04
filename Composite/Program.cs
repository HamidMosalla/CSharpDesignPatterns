using System;
using Composite.LeafObject;
using Composite.ComponentObject;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            More info: https://en.wikipedia.org/wiki/Composite_pattern
            What problems can the Composite design pattern solve?

                A part-whole hierarchy should be represented so that clients can treat part and whole objects uniformly.
                A part-whole hierarchy should be represented as tree structure.

            When defining (1) Part objects and (2) Whole objects that act as containers for Part objects,
            clients must treat them separately, which complicates client code.
            */

            CompositeGraphic root = new CompositeGraphic("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            CompositeGraphic comp = new CompositeGraphic("Composite X");
            comp.AddRange(new Leaf("Leaf XA"), new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));


            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
