using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Strategy
{
    public class Navigator
    {
        private IRoutingStrategy _strategy;
        public void SetStrategy(IRoutingStrategy strategy) => _strategy = strategy;
        public void Execute() => _strategy.Route();
    }
}
