using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.ChainOfResponsibility
{
    public class ValidationHandler : BaseEventHandler
    {
        protected override bool CanHandle(string eventType) => true;
        protected override void Process(string eventType)
            => Logger.Instance.Log($"Валидация события {eventType}");
    }
}
