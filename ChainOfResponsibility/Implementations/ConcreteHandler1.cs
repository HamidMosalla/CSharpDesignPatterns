using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibility.Abstrations;

namespace ChainOfResponsibility.Implementations
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
