using SmartCity.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Adapter
{
    public class OldCamera
    {
        public void TakePicture() => Logger.Instance.Log("Старая камера: снимок сделан");
    }
}
