using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace MoodiesTool
{
    class StickManager
    {
        private Texture _stick;
        float _rotationAngle,_x,_y;
        public float rotationAngle
        { get { return _rotationAngle; }
          set { _rotationAngle = value; } }

        public float X { get { return _x; } set { _x = value; } }
        public float Y { get { return _y; } set { _y = value; } }

        static StickManager _stickmanager = null;
    
        StickManager()
        {
          //  RenderManager.GetRenderManager().RegisterAsRenderable(this);
            _stick = TextureLoader.FromFile(GameAppFramework.GetGameAppFramework().Device, "stick2.png");
            _x = (GameAppFramework.GetGameAppFramework().Device.Viewport.Width / 2)-70;
            _y = (GameAppFramework.GetGameAppFramework().Device.Viewport.Height)-130;
          
           
        }

        public static StickManager GetStick()
        {
            if (_stickmanager == null)
                _stickmanager = new StickManager();
            return _stickmanager;
        }
        public void  Render()
        {
            using (Sprite drawStick = new Sprite(GameAppFramework.GetGameAppFramework().Device))
            {
               
                drawStick.Begin(SpriteFlags.AlphaBlend);
                Matrix matrix = new Matrix();
                matrix = Matrix.Transformation2D(new Vector2(0, 0), 0f, new Vector2(1.0f, 1.0f), new Vector2(_x+45, _y+100), _rotationAngle, new Vector2(0, 0));
                drawStick.Transform = matrix;
                drawStick.Draw(_stick, new Rectangle(0, 0, 0, 0), new Vector3(0, 0, 0), new Vector3(_x,_y, 0), Color.White);
                drawStick.End();
             }
           
        }

  }
}
