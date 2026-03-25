using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Mediator
{
    public class EventMediator : IMediator
    {
        public void Notify(object sender, string ev) => Logger.Instance.Log($"Медиатор: {sender} отправил {ev}");
    }
}
