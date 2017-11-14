using System;
using Composite.ComponentObject;

namespace Composite.LeafObject
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
