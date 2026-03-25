using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.AbstractFactory
{
    public class StandardController : IController
    {
        public void Control() => Logger.Instance.Log("Стандартный контроллер");
    }
}
