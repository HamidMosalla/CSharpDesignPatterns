using System;
using Observer.SubjectObjects;

namespace Observer.ObserverObjects
{
    internal class ConcreteObserver : Observer
    {
        private readonly string _name;

        private string _observerState;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Subject = subject;

            _name = name;
        }

        public ConcreteSubject Subject { get; set; }

        public override void Update()
        {
            _observerState = Subject.SubjectState;

            Console.WriteLine("Observer {0}'s new state is {1}", _name, _observerState);
        }
    }
}