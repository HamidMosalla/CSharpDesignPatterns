using System;
using System.Collections.Generic;
using System.Text;
using Decorator.Component;

namespace Decorator.Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee _decoratedCoffee;

        public CoffeeDecorator(ICoffee c)
        {
            this._decoratedCoffee = c;
        }

        public virtual double GetCost()
        {
            return _decoratedCoffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return _decoratedCoffee.GetIngredients();
        }
    }
}
