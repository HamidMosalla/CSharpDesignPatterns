using System;
using System.Collections.Generic;

namespace Composite.ComponentObject
{
    internal class CompositeGraphic : IGraphic
    {
        private string _name;
        private readonly List<IGraphic> _graphics = new List<IGraphic>();

        public CompositeGraphic(string name)
        {
            _name = name;
        }

        public void Add(IGraphic component)
        {
            _graphics.Add(component);
        }

        public void AddRange(params IGraphic[] graphic)
        {
            _graphics.AddRange(graphic);
        }

        public void Remove(IGraphic component)
        {
            _graphics.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);

            foreach (var component in _graphics)
            {
                component.Display(depth + 2);
            }
        }
    }
}