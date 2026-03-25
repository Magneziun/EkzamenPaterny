using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.ChainOfResponsibility
{
    public abstract class BaseEventHandler
    {
        protected BaseEventHandler? _next; 

        public void SetNext(BaseEventHandler next) => _next = next;

        public void Handle(string eventType)
        {
            if (CanHandle(eventType))
                Process(eventType);
            else if (_next != null)
                _next.Handle(eventType);
        }

        protected abstract bool CanHandle(string eventType);
        protected abstract void Process(string eventType);
    }

}
