using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Memento
{
    public class DeviceMemento
    {
        public string State { get; }
        public DeviceMemento(string state) => State = state;
    }
}
