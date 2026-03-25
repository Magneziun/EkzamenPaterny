using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Strategy
{
    public class ShortestRoute : IRoutingStrategy
    {
        public void Route() => Logger.Instance.Log("Маршрут: самый короткий");
    }
}
