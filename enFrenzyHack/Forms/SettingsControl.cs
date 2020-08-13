using System;
using System.Windows.Forms;
using enFrenzyHack.Helper;

namespace enFrenzyHack
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void GlowUpdate_Scroll(object sender, EventArgs e)
        {
            Int32 value = 251 - (Int32)GlowUpdate.Value;
            glowUpdLabel.Text = "GlowUpdate: " + value;
            Variable.Glow_Update = value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
