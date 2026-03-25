using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Bridge
{
    public class LocalControl : IControlMode
    {
        public void Execute(string command) => Logger.Instance.Log($"Локальное управление: {command}");
    }
}
