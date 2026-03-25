using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Observer
{
    public class EventPublisher
    {
        private List<IObserver> _observers = new();
        public void Subscribe(IObserver obs) => _observers.Add(obs);
        public void Notify(string data) => _observers.ForEach(o => o.Update(data));
    }
}
