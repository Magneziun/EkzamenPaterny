using System;

namespace SmartCity.Creational.Singleton
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> lazy = new(() => new Logger());
        public static Logger Instance => lazy.Value;
        private Logger() { }
        public void Log(string message) => Console.WriteLine($"[Log][{DateTime.Now.ToString("HH:mm:ss")}] {message}");
    }
}