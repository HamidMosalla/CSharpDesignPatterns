using System;
using Composite.ComponentObject;

namespace Composite.LeafObject
{
    internal class Leaf : IGraphic
    {
        private readonly string _name;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }
    }
}
