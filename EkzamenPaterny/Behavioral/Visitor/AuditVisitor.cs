using EkzamenPaterny.Creational.FactoryMethod;
using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Visitor
{
    public class AuditVisitor : IVisitor
    {
        public void Visit(Drone drone) => Logger.Instance.Log("Аудит дрона");
        public void Visit(Camera camera) => Logger.Instance.Log("Аудит камеры");
    }

}
