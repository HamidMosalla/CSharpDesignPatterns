using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Decorator_pattern
                 What problems can the Decorator design pattern solve?
                    Responsibilities should be added to (and removed from) an object dynamically at run-time.
                    A flexible alternative to subclassing for extending functionality should be provided.

                When using subclassing, different subclasses extend a class in different ways.
                But an extension is bound to the class at compile-time and can't be changed at run-time.
            */

            void PrintInfo(ICoffee coffee) => Console.WriteLine("Cost: " + coffee.GetCost() + "; Ingredients: " + coffee.GetIngredients());

            ICoffee c = new SimpleCoffee();
            PrintInfo(c);

            c = new CoffeeWithMilk(c);
            PrintInfo(c);

            c = new CoffeeWithSprinkles(c);
            PrintInfo(c);



            var coffeeWithMilk = new CoffeeWithMilk(new SimpleCoffee());
            PrintInfo(coffeeWithMilk);
        }
    }
}
