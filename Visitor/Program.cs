using System;
using Visitor.Elements;
using Visitor.ObjectStructure;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              More info: https://manski.net/2013/05/the-visitor-pattern-explained
              What problems can the Visitor design pattern solve?

            It should be possible to define a new operation for (some) classe
            s of an object structure without changing the classes.

            When new operations are needed frequently and the object structure consists of many unrelated classes,
            it's inflexible to add new subclasses each time a new operation is required because "[..] distributing
            all these operations across the various node classes leads to a system that's hard to understand, maintain, and change."

             */

            var doc = new Document(new PlainText { Text = "Plain" }, new Hyperlink { Text = "Hyper", Url = "Link" });
            var visitor = new HtmlVisitor();
            doc.Accept(visitor);
            Console.WriteLine($"Plain text plus Hyperlink {visitor.Output}");
        }
    }
}
