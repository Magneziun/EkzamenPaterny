using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.AbstractFactory
{
    public class TemperatureSensor : ISensor
    {
        public void Read() => Logger.Instance.Log("Датчик температуры: 25°C");
    }

}
