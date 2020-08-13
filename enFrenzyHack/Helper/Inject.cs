using enFrenzyHack.Helper;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace enFrenzyHack.BeforeInject
{
    class Inject
    {
        public static Memory mem;
        public static int client_dll;
        public static int engine_dll;

        #region Проверка существования процесса игры и её dll
        public static bool GetDll() //подключение к csgo
        {
            try
            {
                Process csgo = Process.GetProcessesByName("csgo")[0];
                mem = new Memory("csgo");
                foreach (ProcessModule module in csgo.Modules)
                {
                    if (module.ModuleName == "client.dll")
                    {
                        client_dll = (int)module.BaseAddress;
                    }
                }
                foreach (ProcessModule processModule in csgo.Modules)
                {
                    if (processModule.ModuleName == "engine.dll")
                    {
                        engine_dll = processModule.BaseAddress.ToInt32();
                    }
                }
                return true;
            }
            catch
            {
                Thread.Sleep(500);
                return false;
            }
        }
        #endregion

        #region CheckCSGO (если NN выходит из игры, выключение чита)
        public static void Check()
        {
            while (Variable.check == true)
            {
                try
                {
                    Process csgo = Process.GetProcessesByName("csgo")[0];
                    mem = new Memory("csgo");
                    foreach (ProcessModule module in csgo.Modules)
                    {
                        if (module.ModuleName == "client.dll")
                            client_dll = (int)module.BaseAddress;
                    }
                    foreach (ProcessModule processModule in csgo.Modules)
                    {
                        if (processModule.ModuleName == "engine.dll")
                        {
                            engine_dll = processModule.BaseAddress.ToInt32();
                        }
                    }
                    Thread.Sleep(1000);
                }
                catch
                {
                    Thread.Sleep(1000);
                    Variable.check = false;

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
            }
        }
        #endregion
    }
}
