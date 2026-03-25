using EkzamenPaterny.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(Drone drone);
        void Visit(Camera camera);
    }
}
