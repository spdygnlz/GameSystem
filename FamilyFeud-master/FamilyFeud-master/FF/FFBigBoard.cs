using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FF
{
    public partial class FFBigBoard : Form
    {
        public FFBigBoard()
        {
            InitializeComponent();
        }

        private void FFBigBoard_Load(object sender, EventArgs e)
        {
            //Screen screen = default(Screen);

            this.Location = new Point(0, 0);
        }

        private void StrikeDisplayTimer_Tick(object sender, EventArgs e)
        {
            StrikeOutbox.Image = Image.FromFile("data\\gfx\\nostrike.png");
            StrikeDisplayTimer.Enabled = false;
        }
    }
}
