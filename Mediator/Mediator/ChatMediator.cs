using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.Colleague;

namespace Mediator.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<IUser> _users;

        public ChatMediator()
        {
            this._users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            this._users.Add(user);
        }

        public void SendMessage(string msg, IUser incommingUser)
        {
            foreach (var user in _users.Where(user => user != incommingUser))
            {
                user.Receive(msg);
            }
        }
    }
}
