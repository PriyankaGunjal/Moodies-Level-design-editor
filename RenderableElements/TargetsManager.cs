using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using MoodiesTool.GameManagers;



namespace MoodiesTool
{
   
    class TargetsManager 
    {
        private List<List<Moodie>> _moodielist;
        static TargetsManager _target = null;
        public List<List<Moodie>> MoodieList
        {
            get { return _moodielist; }
            set {_moodielist = value; }
        }

      TargetsManager()
        {
          //  RenderManager.GetRenderManager().RegisterAsRenderable(this);
            int x = 0,y= 0;
            MoodieList = new List<List<Moodie>>();        
            for (int height=0;height<5;height++)
            {
                MoodieList.Add(CreateSublist(x,y));
                x = 0;
                y += 50;

                
            }

        }
        public static TargetsManager CreateTargets()
        {
            if (_target == null)
                _target = new TargetsManager( );
            return _target;

        }

       List<Moodie> CreateSublist(int x,int y)
        {
            int devicesize = GameAppFramework.GetGameAppFramework().Device.Viewport.Width;
            Random r = new Random();
            string image;
            List<Moodie> sublist = new List<Moodie>();
            while (x+50 <devicesize)
            {
                var  randomMoodie = r.Next(1, 5);
                image = "image" + randomMoodie + ".png";
                sublist.Add(new Moodie(TextureLoader.FromFile(GameAppFramework.GetGameAppFramework().Device, image), x, y, randomMoodie));
                x += 50;
            }
            return sublist;
        }

       
        void IncreamentYCoordinate()
        {
            foreach (var sublist in MoodieList)
            {
                foreach (Moodie moodie in sublist)
                {
                    moodie.SetYCoordinate(moodie.GetYCoordinate() + 50);
                }

            }
        }
      
        public void AddTargetList()
        {
            
            MoodieList.Add(CreateSublist( 0, MoodieList[MoodieList.Count-1][0].GetYCoordinate()+50));
          
        }
        public void Render()
        {
            foreach (var Sublist in MoodieList)
            {
                foreach (Moodie moodie in Sublist)
                {
                    if(moodie.getShowFlag())
                        moodie.DrawMoodie();
                }
            }
        }
      
    }
}
