using System;
using Mediator.Colleague;
using Mediator.Mediator;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * More info: https://en.wikipedia.org/wiki/Mediator_pattern
             What problems can the Mediator design pattern solve?
              Tight coupling between a set of interacting objects should be avoided.
              It should be possible to change the interaction between a set of objects independently.

            Defining a set of interacting objects by accessing and updating each other directly is inflexible because it tightly couples the objects to each other and makes
            it impossible to change the interaction independently from (without having to change) the objects.
            
            And it stops the objects from being reusable and makes them hard to test.
            Tightly coupled objects are hard to implement, change, test, and reuse because they refer to and know about many different objects.
             */

            IChatMediator mediator = new ChatMediator();
            IUser user1 = new User(mediator, "Hamid");
            IUser user2 = new User(mediator, "Lisa");
            IUser user3 = new User(mediator, "Saurabh");
            IUser user4 = new User(mediator, "David");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);

            user1.Send("Hi All");
        }
    }
}
