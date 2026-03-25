using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Adapter
{
    public class CameraAdapter : INewCamera
    {
        private readonly OldCamera _oldCamera;
        public CameraAdapter(OldCamera oldCamera) => _oldCamera = oldCamera;
        public void Capture() => _oldCamera.TakePicture();
    }
}
