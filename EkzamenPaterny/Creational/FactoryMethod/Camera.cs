using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.FactoryMethod
{
    public class Camera : IDevice
    {
        public void Activate() => Logger.Instance.Log("Камера активирована");
    }

}
