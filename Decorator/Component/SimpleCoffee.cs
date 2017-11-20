using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1;
        }

        public string GetIngredients()
        {
            return "Coffee";
        }
    }
}
