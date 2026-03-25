using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Command
{
    public class SendDroneCommand : ICommand
    {
        public void Execute() => Logger.Instance.Log("Дрон отправлен");
    }
}
