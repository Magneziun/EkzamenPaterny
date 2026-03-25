using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.Prototype
{
    public abstract class DevicePrototype
    {
        public string Id { get; set; }
        public abstract DevicePrototype Clone();
    }

}
