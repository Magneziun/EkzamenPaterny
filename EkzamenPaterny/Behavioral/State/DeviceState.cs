using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.State
{
    public abstract class DeviceState
    {
        public abstract void Handle(DeviceContext context);
    }
}
