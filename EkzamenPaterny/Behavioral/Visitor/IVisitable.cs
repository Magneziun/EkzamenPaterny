using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
