using EkzamenPaterny.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Visitor
{
    public class VisitableDrone : Drone, IVisitable
    {
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }

}
