using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.State
{
    public class DeviceContext
    {
        public DeviceState State { get; set; }
        public void Request() => State.Handle(this);
    }
}
