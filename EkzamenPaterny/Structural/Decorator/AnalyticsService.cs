using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Decorator
{
    public class AnalyticsService : IService
    {
        public void Execute() => Logger.Instance.Log("Аналитика: построен отчёт");
    }
}
