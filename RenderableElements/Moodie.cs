using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace MoodiesTool
{
   public class Moodie
    {
        Texture texture;
        int x, y;
        int type;
        private bool showFlag;

        public Moodie(Texture texture,int x,int y,int type)
        {
            this.texture =texture;
            this.x = x;
            this.y = y;
            this.type = type;
            showFlag = true;
        }
        public void DrawMoodie()
        {
            try
            {
                StickManager stick = StickManager.GetStick();
                using (Sprite DrawMoodie = new Sprite(GameAppFramework.GetGameAppFramework().Device))
                {
                    DrawMoodie.Begin(SpriteFlags.AlphaBlend);
                    Matrix matrix = new Matrix();
                    matrix = Matrix.Transformation2D(new Vector2(0, 0), 0f, new Vector2(1.0f, 1.0f), new Vector2(stick.X + 45, stick.Y + 100), 0.0f, new Vector2(0, 0));
                    DrawMoodie.Transform = matrix;
                    DrawMoodie.Draw(texture, new Rectangle(0, 0, 0, 0), new Vector3(0, 0, 0), new Vector3(x, y, 0), Color.White);
                    DrawMoodie.End();

                }
            }
            catch (Exception ex) { }
        }

        public int GetXCoordinate()
        {
            return x;
        }
        public int GetYCoordinate()
        {
            return y;
        }
       
        public void SetYCoordinate(int y)
        {
            this.y = y;
        }
       
        public Texture getTexture()
        {
            return texture;
        }

        public bool getShowFlag()
        {
            return showFlag;
        }
    }


}
