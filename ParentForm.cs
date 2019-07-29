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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            Tools tools = new Tools();
            tools.MdiParent = this;
            tools.Show();
            
           // this.Controls.Add(new MyFavControl());

            GameApp.GetGameApp().MdiParent = this;
            GameApp.GetGameApp().Show();
            tools.Show();
         
            //GameApp.GetGameApp().RectangleToScreen(new Rectangle(0, 0, 992, 864));

            // tools.RectangleToScreen(new Rectangle(992, 864, 1168, 910));

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ParentForm_Shown(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
