using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintInfo(ICoffee coffee) => Console.WriteLine("Cost: " + coffee.GetCost() + "; Ingredients: " + coffee.GetIngredients());

            ICoffee c = new SimpleCoffee();
            PrintInfo(c);

            c = new CoffeeWithMilk(c);
            PrintInfo(c);

            c = new CoffeeWithSprinkles(c);
            PrintInfo(c);
        }
    }
}
