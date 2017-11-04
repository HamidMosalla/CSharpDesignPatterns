using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Mediator;

namespace Mediator.Colleague
{
    public interface IUser
    {
        void Send(string msg);
        void Receive(string msg);
    }
}
