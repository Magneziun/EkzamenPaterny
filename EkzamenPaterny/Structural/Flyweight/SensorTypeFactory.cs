using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Flyweight
{
    public class SensorTypeFactory
    {
        private static Dictionary<string, SensorType> _cache = new();
        public static SensorType GetSensorType(string type, string unit)
        {
            if (!_cache.ContainsKey(type))
                _cache[type] = new SensorType(type, unit);
            return _cache[type];
        }
    }
}
