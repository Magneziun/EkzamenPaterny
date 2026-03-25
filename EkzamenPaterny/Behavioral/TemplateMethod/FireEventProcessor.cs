using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.TemplateMethod
{
    public class FireEventProcessor : EventProcessor
    {
        protected override void Handle() => Logger.Instance.Log("Пожар: вызов пожарных");
    }

}
