using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.AbstractFactory
{
    public interface ICityInfrastructureFactory
    {
        ITransport CreateTransport();
        IController CreateController();
        ISensor CreateSensor();
    }

}
