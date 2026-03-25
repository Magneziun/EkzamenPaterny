using EkzamenPaterny.Creational.Singleton;
using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Facade
{
    public class CityFacade
    {
        private readonly Logger _logger = Logger.Instance;
        private readonly ConfigManager _config = ConfigManager.Instance;
        public void StartDay()
        {
            _logger.Log("Начало дня в городе");
            _logger.Log($"Конфигурация: {_config.Get("city")}");
            // просто имитация работы
        }
    }
}
