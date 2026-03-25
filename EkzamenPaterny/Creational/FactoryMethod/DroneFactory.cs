using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.FactoryMethod
{
    public class DroneFactory : DeviceFactory
    {
        public override IDevice CreateDevice() => new Drone();
    }

}
