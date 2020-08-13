using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using enFrenzyHack.Function;
using enFrenzyHack.Helper;

namespace enFrenzyHack
{
    public partial class LegitControl : UserControl
    {
        public LegitControl()
        {
            InitializeComponent();
        }

        private void GlowChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (GlowChecked.Checked)
            {
                Thread glow = new Thread(GlowHack.ToGlow);
                Variable.glow_is = true;
                glow.Start();
            }
            else
            {
                Variable.glow_is = false;
            }
        }
    }
}
