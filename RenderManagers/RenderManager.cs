using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace MoodiesTool.GameManagers
{
    class RenderManager
    {
        private static RenderManager _renderer;
      
        RenderManager()
        {
           
        }
       public static RenderManager GetRenderManager()
        {
            return _renderer  =_renderer ?? new RenderManager();
        }

      
        public void Render() // TODO : move this to more appropriate place
        {
            try
            {
                if (GameAppFramework.GetGameAppFramework().Device != null)
                {
                    
                        GameAppFramework.GetGameAppFramework().Device.Clear(ClearFlags.Target, GameAppFramework.GetGameAppFramework().DeviceColor, 0, 1);
                        GameAppFramework.GetGameAppFramework().Device.BeginScene();
                        TargetsManager.CreateTargets().Render();
                        StickManager.GetStick().Render();
                        PlayerManager.CreatePlayerManager().Render();
                        GameAppFramework.GetGameAppFramework().Device.EndScene();
                        GameAppFramework.GetGameAppFramework().Device.Present();
                  
                  
                }
            }
            catch (Exception) { }
            IOManager.GetIoManager().WriteFile();

        }
    }
}
