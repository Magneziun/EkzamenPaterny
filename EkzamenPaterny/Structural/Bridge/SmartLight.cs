using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Bridge
{
    public class SmartLight : DeviceBridge
    {
        public SmartLight(IControlMode controlMode) : base(controlMode) { }
        public override void Operate() => _controlMode.Execute("Включить свет");
    }
}
