using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace enFrenzyHack
{
    public partial class enFrenzyHackForm : Form
    {
        #region Передвижение формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public static bool _overlayStatus;
        GlobalKeyboardHook gHook;

        public static PopupNotifier notifier = null;

        public enFrenzyHackForm()
        {
            InitializeComponent();
            ExitButton.BringToFront();
        }

        #region LegitBotButton
        private void LegitBotButton_Click(object sender, EventArgs e)
        {
            legitControl1.BringToFront();
            ExitButton.BringToFront();
        }
        #endregion

        #region RageBotButton
        private void RageBotButton_Click(object sender, EventArgs e)
        {
            rageControl1.BringToFront();
            ExitButton.BringToFront();
        }
        #endregion

        #region SettingsButton
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settingsControl1.BringToFront();
            ExitButton.BringToFront();
        }
        #endregion

        #region DebugButton
        private void DebugButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/frk1/hazedumper/blob/master/csgo.cs");
        }
        #endregion

        private void InjectButton_Click(object sender, EventArgs e)
        {
            if (!Inject.GetDll())
            {
                StatusLabel.Text = "NotFound";
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Left = 0;

                LegitBotButton.Enabled = false;
                legitControl1.Enabled = false;
                RageBotButton.Enabled = false;
                rageControl1.Enabled = false;
                SettingsButton.Enabled = false;
                settingsControl1.Enabled = false;
                DebugButton.Enabled = true;
            }
            else
            {
                StatusLabel.Text = "Found";
                StatusLabel.ForeColor = Color.Green;
                StatusLabel.Left = 22;

                LegitBotButton.Enabled = true;
                legitControl1.Enabled = true;
                RageBotButton.Enabled = true;
                rageControl1.Enabled = true;
                SettingsButton.Enabled = true;
                settingsControl1.Enabled = true;
                DebugButton.Enabled = true;

                Thread.Sleep(500);

                //checkcsgo
                Thread checkcs = new Thread(Inject.Check);
                Variable.check = true;
                checkcs.Start();

                //уведомление в начале
                string notif_text = "Press 'Insert' to enable Cheat";
                Notifier.Notif(notif_text);

                //распаковка hazedumper и config.json
                string temp_hazedumper = Application.StartupPath + "/hazedumper.exe";
                if (File.Exists(temp_hazedumper))
                    File.Delete(temp_hazedumper);
                File.WriteAllBytes(temp_hazedumper, Properties.Resources.hazedumper);
                string temp_config = Application.StartupPath + "/config.json";
                if (File.Exists(temp_config))
                    File.Delete(temp_config);
                File.WriteAllText(temp_config, Properties.Resources.config);

                _overlayStatus = false;

                OffsetsUpdater.DeleteFile();
                OffsetsUpdater.GetOffsets();

                //проверка оффсетов на их роботоспособность
                bool isOkay = true;
                string keyWord = "WARN";
                var lines = File.ReadLines(Application.StartupPath + $"/hazedumper.log");
                string result = string.Join("\n", lines.Where(s => s.IndexOf(keyWord, StringComparison.InvariantCultureIgnoreCase) >= 0));
                if (result.Length != 0)
                {
                    MessageBox.Show(result, "Offsets are not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isOkay = false;
                }

                OffsetsUpdater.Update();
                OffsetsUpdater.DeleteFile();
                if (File.Exists(temp_hazedumper))
                    File.Delete(temp_hazedumper);
                if (File.Exists(temp_config))
                    File.Delete(temp_config);

                if (isOkay == false)
                {
                    Process[] listprosecc = Process.GetProcesses();
                    try
                    {
                        foreach (Process proc in Process.GetProcessesByName(Variable.CheatName))
                            proc.Kill();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //отслеживание клавиши Insert
                gHook = new GlobalKeyboardHook();
                gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
                foreach (Keys key in Enum.GetValues(typeof(Keys)))
                    gHook.HookedKeys.Add(key);
                gHook.hook();
            }
        }

        #region Insert (gHook)
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text += ((char)e.KeyValue).ToString();
            if (textBox1.Text == "-")
            {
                Variable.on_off = Variable.on_off + 1;
                if (Variable.on_off % 2 == 0)
                {
                    TopMost = false;
                    Visible = false;
                    Enabled = false;
                    ShowIcon = false;
                    ShowInTaskbar = false;
                    WindowState = FormWindowState.Minimized;
                }
                else
                {
                    TopMost = true;
                    Visible = true;
                    Enabled = true;
                    ShowIcon = true;
                    ShowInTaskbar = true;
                    WindowState = FormWindowState.Normal;
                    Activate();
                }
            }
            textBox1.Clear();
        }
        #endregion

        #region Minimaze и Exit Buttons
        private void MinimazeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Process[] listprosecc = Process.GetProcesses();
            try
            {
                foreach (Process proc in Process.GetProcessesByName(Variable.CheatName))
                    proc.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}