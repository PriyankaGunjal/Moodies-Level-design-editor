using System;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace MoodiesTool
{
    public class GameAppFramework 
    {
        public Device Device {get; set; }

        public Color DeviceColor{get; set; }

        private static GameAppFramework _gameframework = null;

       public void InitializeDevice()
        {
            Device = new Device(0, DeviceType.Hardware,GameApp.GetGameApp().Handle, CreateFlags.HardwareVertexProcessing, InitializePresentParameters());
            DeviceColor = Color.Black;
        }

        private PresentParameters InitializePresentParameters()
        {
            var presentparameter = new PresentParameters
            {
                Windowed = true,
                SwapEffect = SwapEffect.Discard
            };
            return presentparameter;
        }

        public static GameAppFramework GetGameAppFramework()
        {
            return _gameframework  = _gameframework?? new GameAppFramework();
        }
        
    }
}
