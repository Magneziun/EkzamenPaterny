using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Decorator
{
    public abstract class ServiceDecorator : IService
    {
        protected IService _wrappee;
        public ServiceDecorator(IService wrappee) => _wrappee = wrappee;
        public virtual void Execute() => _wrappee.Execute();
    }
}
