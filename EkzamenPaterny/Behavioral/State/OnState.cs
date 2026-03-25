using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.State
{
    public class OnState : DeviceState
    {
        public override void Handle(DeviceContext context) => Logger.Instance.Log("Устройство включено");
    }
}
