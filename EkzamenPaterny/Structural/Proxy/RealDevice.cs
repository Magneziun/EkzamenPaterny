using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Proxy
{
    public class RealDevice : IDeviceAccess
    {
        public void Access() => Logger.Instance.Log("Реальное устройство: доступ разрешён");
    }
}
