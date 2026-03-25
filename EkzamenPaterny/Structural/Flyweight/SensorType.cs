using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Flyweight
{
    public class SensorType
    {
        public string Type { get; }
        public string Unit { get; }
        public SensorType(string type, string unit) { Type = type; Unit = unit; }
    }
}
