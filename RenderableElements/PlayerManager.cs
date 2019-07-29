using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;
using MoodiesTool.GameManagers;

namespace MoodiesTool
{
   
    class PlayerManager
    {
        Moodie _player;
        int _playerXCenter, _playerYCenter;
        float _playerRotationAngle;
        private bool _wall = false;
        public int Playerstartx, Playerstarty;
        static PlayerManager _playermanager;
       
        PlayerManager()
        {
           // RenderManager.GetRenderManager().RegisterAsRenderable(this);
            CreateNewPlayer();


        }

        public void CreateNewPlayer()
        {
            _player = null;
            Random r = new Random();
            int randomMoodie = 1;
            randomMoodie = r.Next(1, 5);
            string image = "image" + randomMoodie + ".png";

            _player = new Moodie(TextureLoader.FromFile(GameAppFramework.GetGameAppFramework().Device, image),
                (GameAppFramework.GetGameAppFramework().Device.Viewport.Width / 2) - 60
                , GameAppFramework.GetGameAppFramework().Device.Viewport.Height - 185, randomMoodie);
            Playerstartx = GetPlayerX();
            _wall = false;
           
        }
        public static PlayerManager CreatePlayerManager()
        {
            return _playermanager = _playermanager ?? new PlayerManager();
        } 
     
        public int GetPlayerX()
        {
            return _player.GetXCoordinate();

        }
        public int GetPlayerY()
        {
            return _player.GetYCoordinate();

        }

     public void Render()
        {
            StickManager stick = StickManager.GetStick();
            using (Sprite DrawPlayer = new Sprite(GameAppFramework.GetGameAppFramework().Device))
            {
                try
                {

                    DrawPlayer.Begin(SpriteFlags.AlphaBlend);
                    Matrix matrix = new Matrix();
                    matrix = Matrix.Transformation2D(new Vector2(0, 0), 0f, new Vector2(1.0f, 1.0f), new Vector2(GetPlayerX()+25, GetPlayerY()+25),0.1f, new Vector2(0, 0));//(float)(Math.PI - playerRotationAngle), new Vector2(0,0));
                    DrawPlayer.Transform = matrix;
                    DrawPlayer.Draw(_player.getTexture(), new Rectangle(0, 0, 0, 0), new Vector3(0, 0, 0), new Vector3(GetPlayerX(), GetPlayerY(), 0), Color.White);
                    DrawPlayer.End();
                }
                catch (Exception e) { }
            }
        }
        
    }
}
