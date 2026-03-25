using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Observer
{
    public class SecurityService : IObserver
    {
        public void Update(string data) => Logger.Instance.Log($"Безопасность: событие {data}");
    }
}
