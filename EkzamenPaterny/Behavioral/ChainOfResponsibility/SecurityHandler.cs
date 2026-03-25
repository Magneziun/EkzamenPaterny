using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.ChainOfResponsibility
{
    public class SecurityHandler : BaseEventHandler
    {
        protected override bool CanHandle(string eventType) => eventType == "fire";
        protected override void Process(string eventType)
            => Logger.Instance.Log($"Обработка безопасности для {eventType}");
    }
}
