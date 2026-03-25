using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Proxy
{
    public class DeviceProxy : IDeviceAccess
    {
        private RealDevice _realDevice;
        private string _userRole;
        public DeviceProxy(string userRole) => _userRole = userRole;
        public void Access()
        {
            if (_userRole == "Admin")
            {
                _realDevice ??= new RealDevice();
                _realDevice.Access();
            }
            else
                Logger.Instance.Log("Доступ запрещён: недостаточно прав");
        }
    }
}
