using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.Builder
{
    public class Building
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public bool HasParking { get; set; }
        public void Describe() => Logger.Instance.Log($"Здание {Name}, этажей {Floors}, парковка: {HasParking}");
    }
}
