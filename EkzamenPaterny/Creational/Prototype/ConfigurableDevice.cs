using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.Prototype
{
    public class ConfigurableDevice : DevicePrototype
    {
        public string Model { get; set; }
        public override DevicePrototype Clone() => new ConfigurableDevice { Id = this.Id, Model = this.Model };
    }
}
