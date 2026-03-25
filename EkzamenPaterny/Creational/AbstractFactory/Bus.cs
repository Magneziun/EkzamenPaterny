using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.AbstractFactory
{
    public class Bus : ITransport
    {
        public void Move() => Logger.Instance.Log("Автобус движется");
    }

}
