using System;
using Observer.ObserverObjects;
using Observer.SubjectObjects;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern

            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));

            s.Attach(new ConcreteObserver(s, "Y"));

            s.Attach(new ConcreteObserver(s, "Z"));


            // Change subject and notify observers

            s.SubjectState = "ABC";

            s.Notify();


            Console.ReadKey();
        }
    }
}
