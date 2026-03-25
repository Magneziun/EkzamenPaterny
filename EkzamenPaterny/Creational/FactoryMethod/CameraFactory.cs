using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.FactoryMethod
{
    public class CameraFactory : DeviceFactory
    {
        public override IDevice CreateDevice() => new Camera();
    }
}
