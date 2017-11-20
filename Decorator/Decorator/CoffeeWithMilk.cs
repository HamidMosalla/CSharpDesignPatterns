using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;

namespace Decorator.Decorator
{
    public class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(ICoffee c) : base(c) { }

        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Milk";
        }
    }
}
