using System;
using TemplateMethod.DrinkExample.Implementations;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Template_method_pattern
             Usage
             The template method is used in frameworks, where each implements the invariant parts of a domain's architecture, leaving "placeholders" for customization options.
             This is an example of inversion of control. The template method is used for the following reasons:

             Let subclasses implement varying behavior (through method overriding).

             Avoid duplication in the code: the general workflow structure is implemented once in the abstract class's algorithm,
             and necessary variations are implemented in the subclasses.

             Control at what point(s) subclassing is allowed. As opposed to a simple polymorphic override,
             where the base method would be entirely rewritten allowing radical change to the workflow, only the specific details of the workflow are allowed to change.
            */

            var tea = new Tea();

            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();

            Console.WriteLine("====================================================================");

            var coffee = new Coffee();

            coffee.WantsCondiments = true;
            coffee.Prepare();

            Console.ReadKey();
        }
    }
}
