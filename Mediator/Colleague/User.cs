using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediator;

namespace Mediator.Colleague
{
    public class User : IUser
    {
        private readonly IChatMediator _mediator;
        private readonly string _name;

        public User(IChatMediator med, string name)
        {
            this._mediator = med;
            this._name = name;
        }

        public void Send(string msg)
        {
            Console.WriteLine(this._name + ": Sending Message=" + msg);
            _mediator.SendMessage(msg, this);
        }

        public void Receive(string msg)
        {
            Console.WriteLine(this._name + ": Received Message:" + msg);
        }
    }
}
