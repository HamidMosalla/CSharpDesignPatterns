using System;
using Composite.LeafObject;
using Composite.ComponentObject;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            ComponentObject.Composite root = new ComponentObject.Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            ComponentObject.Composite comp = new ComponentObject.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

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
