using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Bridge
{
    public interface IControlMode
    {
        void Execute(string command);
    }
}
