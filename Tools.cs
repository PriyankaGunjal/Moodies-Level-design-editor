using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodiesTool
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
           
        }
        private void btnColor_MouseClick_1(object sender, MouseEventArgs e)
        {
            DialogResult colorResult = colorDialog.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                GameAppFramework.GetGameAppFramework().DeviceColor = colorDialog.Color;
            }
            GameApp.GetGameApp().Renderer.RunWorkerAsync();

        }
        private void slider_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = true;
        }
        private void Tools_MouseClick(object sender, MouseEventArgs e)
        {
            trackBar1.Visible = false;
        }

        private void Slider_ValueChanged(object sender, EventArgs e)
        {
            SliderManager.GetSliderManager().CurrentValue = trackBar1.Value;
            SliderManager.GetSliderManager().HandleEvent();
           GameApp.GetGameApp().Renderer.RunWorkerAsync();
        }
    }
}
