using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Bridge
{
    public class RemoteControl : IControlMode
    {
        public void Execute(string command) => Logger.Instance.Log($"Удалённое управление: {command}");
    }

}
