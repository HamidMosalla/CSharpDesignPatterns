using System;
using System.Collections.Generic;

namespace Composite.ComponentObject
{
    internal class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}