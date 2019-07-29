using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodiesTool
{
    class IOManager
    {
        private static IOManager _ioManager;
        private string text;

        public static IOManager GetIoManager()
        {
            return _ioManager = _ioManager ?? new IOManager();
        }

        public void WriteFile()
        {
            text = "" + TargetsManager.CreateTargets().MoodieList.Count + "\n" + " " +
                   GameAppFramework.GetGameAppFramework().DeviceColor.ToString();
            System.IO.File.WriteAllText(@"D:\c# projects\GameData.txt",text);
        }
           
    }
}
