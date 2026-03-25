using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.AbstractFactory
{
    public class CityAFactory : ICityInfrastructureFactory
    {
        public ITransport CreateTransport() => new Bus();
        public IController CreateController() => new StandardController();
        public ISensor CreateSensor() => new TemperatureSensor();
    }

}
