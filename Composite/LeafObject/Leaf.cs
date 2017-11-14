using System;
using Composite.ComponentObject;

namespace Composite.LeafObject
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name) { }


        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
