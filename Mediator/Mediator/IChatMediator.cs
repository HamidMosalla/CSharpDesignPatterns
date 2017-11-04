using Mediator.Colleague;

namespace Mediator.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string msg, IUser user);
        void AddUser(IUser user);
    }
}
