using System;
using TemplateMethod.Abstraction;

namespace TemplateMethod.Implementations
{
    class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Add Coffee Grounds to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add Milk and Sugar");
        }

    }
}
