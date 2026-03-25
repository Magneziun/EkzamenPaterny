using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Memento
{
    public class DeviceOriginator
    {
        public string State { get; set; }
        public DeviceMemento Save() => new(State);
        public void Restore(DeviceMemento m) => State = m.State;
    }
}
