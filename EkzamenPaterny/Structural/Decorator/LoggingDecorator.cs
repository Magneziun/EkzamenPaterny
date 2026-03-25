using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Decorator
{
    public class LoggingDecorator : ServiceDecorator
    {
        public LoggingDecorator(IService wrappee) : base(wrappee) { }
        public override void Execute()
        {
            Logger.Instance.Log("Вызов сервиса начат");
            base.Execute();
            Logger.Instance.Log("Вызов сервиса завершён");
        }
    }
}
