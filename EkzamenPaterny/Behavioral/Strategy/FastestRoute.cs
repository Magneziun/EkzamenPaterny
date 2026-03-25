using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Strategy
{
    public class FastestRoute : IRoutingStrategy
    {
        public void Route() => Logger.Instance.Log("Маршрут: самый быстрый");
    }
}
