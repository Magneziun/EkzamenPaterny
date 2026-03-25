using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.TemplateMethod
{
    public abstract class EventProcessor
    {
        public void Process()
        {
            Validate();
            Handle();
            Log();
        }
        protected virtual void Validate() => Logger.Instance.Log("Валидация (шаблон)");
        protected abstract void Handle();
        protected virtual void Log() => Logger.Instance.Log("Логирование (шаблон)");
    }
}
