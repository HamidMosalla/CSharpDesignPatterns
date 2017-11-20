using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;

namespace Decorator.Decorator
{
    class CoffeeWithSprinkles : CoffeeDecorator
    {
        public CoffeeWithSprinkles(ICoffee c) : base(c) { }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Sprinkles";
        }
    }
}
