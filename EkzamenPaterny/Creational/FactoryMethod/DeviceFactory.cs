using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.FactoryMethod
{
    public abstract class DeviceFactory
    {
        public abstract IDevice CreateDevice();
    }

}
