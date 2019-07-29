using System;
using System.ComponentModel;
using System.Windows.Forms;
using MoodiesTool.GameManagers;

namespace MoodiesTool
{
    public partial class GameApp : Form
    {
       private static GameApp _gameapp = null;
       private  GameApp()
        {
            InitializeComponent();
           //Tools tool = new Tools();
            //tool.Show();
        }

        public static GameApp GetGameApp()  
        {
            return _gameapp = _gameapp ?? new GameApp();
        }

        private void GameApp_Paint(object sender, PaintEventArgs e)
        {
            var afmeAppFrameWork = GameAppFramework.GetGameAppFramework();
            afmeAppFrameWork?.InitializeDevice();
            RenderManager.GetRenderManager().Render();
        }

        private void Renderer_DoWork(object sender, DoWorkEventArgs e)
        {
            RenderManager.GetRenderManager().Render();
        }

        private void GameApp_Load(object sender, EventArgs e)
        {
            new Tools().Show();
        }
    }
}
