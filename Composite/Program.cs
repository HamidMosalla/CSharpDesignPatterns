using System;
using Composite.LeafObject;
using Composite.ComponentObject;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {


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
