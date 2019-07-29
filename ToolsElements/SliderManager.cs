using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodiesTool
{
    class SliderManager
    {
        private static SliderManager _sliderManager;
        private int _previousvalue;
        private int _currentvalue;
      
        public int priviousvalue { get { return _previousvalue; } set { _previousvalue = value; }}
        public int CurrentValue { get { return _currentvalue; } set { _currentvalue = value; } }

        SliderManager()
        {
            
        }

        public static  SliderManager GetSliderManager()
        {
            if(_sliderManager==null)
                _sliderManager=new SliderManager();
            return _sliderManager;
        }
        public void Reset()
        {
            _previousvalue = 0;
            _currentvalue = 0;
       
        }


        public void HandleEvent()
        {
            if (
                TargetsManager.CreateTargets().MoodieList[TargetsManager.CreateTargets().MoodieList.Count - 1][0]
                    .GetYCoordinate() < PlayerManager.CreatePlayerManager().GetPlayerY()+100)
            {
                if(_previousvalue<_currentvalue)
                    TargetsManager.CreateTargets().AddTargetList();
                else if(_previousvalue > _currentvalue)
                     RemoveTargets();
                _previousvalue = _currentvalue;
            }
        }
       
       void RemoveTargets()
        {
            TargetsManager.CreateTargets().MoodieList.RemoveAt(TargetsManager.CreateTargets().MoodieList.Count-1);
        }
    }
}
