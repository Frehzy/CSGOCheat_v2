using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace enFrenzyHack.Helper
{
    class Notifier
    {
        public static void Notif(string notif_text)
        {
            enFrenzyHackForm.notifier = new PopupNotifier();
            enFrenzyHackForm.notifier.Image = Properties.Resources.NotifierImage;
            enFrenzyHackForm.notifier.ImageSize = new Size(96, 96);

            enFrenzyHackForm.notifier.TitleColor = Color.Purple;
            enFrenzyHackForm.notifier.HeaderColor = Color.Red;
            enFrenzyHackForm.notifier.BodyColor = Color.DarkGray;

            enFrenzyHackForm.notifier.TitleText = Variable.CheatName;
            enFrenzyHackForm.notifier.ContentText = notif_text;

            enFrenzyHackForm.notifier.Popup();
        }
    }
}
