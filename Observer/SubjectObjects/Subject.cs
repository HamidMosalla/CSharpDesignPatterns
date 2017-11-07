using System.Collections.Generic;

namespace Observer.SubjectObjects
{
    internal abstract class Subject
    {
        private readonly List<ObserverObjects.Observer> _observers = new List<ObserverObjects.Observer>();

        public void Attach(ObserverObjects.Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(ObserverObjects.Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ObserverObjects.Observer o in _observers) o.Update();
        }
    }
}