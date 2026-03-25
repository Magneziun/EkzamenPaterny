using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.Singleton
{
    public sealed class ConfigManager
    {
        private static readonly Lazy<ConfigManager> lazy = new(() => new ConfigManager());
        public static ConfigManager Instance => lazy.Value;
        private ConfigManager() { }
        public string Get(string key) => key switch { "city" => "Smart City", _ => "default" };
    }
}
