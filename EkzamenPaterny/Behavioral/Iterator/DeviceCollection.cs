using EkzamenPaterny.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Iterator
{
    public class DeviceCollection : IEnumerable<IDevice>
    {
        private List<IDevice> _devices = new();
        public void Add(IDevice device) => _devices.Add(device);
        public IEnumerator<IDevice> GetEnumerator() => _devices.GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
