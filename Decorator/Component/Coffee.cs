using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component
{
    public interface ICoffee
    {
         double GetCost();
         string GetIngredients();
    }
}
