using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Bridge
{
    public abstract class DeviceBridge
    {
        protected IControlMode _controlMode;
        public DeviceBridge(IControlMode controlMode) => _controlMode = controlMode;
        public abstract void Operate();
    }
}
