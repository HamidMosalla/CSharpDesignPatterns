using System;
using ChainOfResponsibility.Abstrations;
using ChainOfResponsibility.Implementations;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * More info: https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern
             * http://www.dofactory.com/net/chain-of-responsibility-design-pattern
            What problems can the Chain of Responsibility design pattern solve?
               Coupling the sender of a request to its receiver should be avoided.
               It should be possible that more than one receiver can handle a request.

            Implementing a request directly within the class that sends the request is inflexible because it couples the class to a particular receiver and makes it impossible
            to support multiple receivers.
            */


            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
