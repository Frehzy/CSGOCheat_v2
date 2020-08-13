using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System.Runtime.InteropServices;
using System.Threading;

namespace enFrenzyHack.Function
{
    class BhopHack
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);
        public static void ToBunnyHop() //проверка пробела и перезапись значения. Если простым языком: "Если нажата клавиша 32 (пробел) (её значение не равно 0), то...
                                        //Запиши в dwForceJump флаг 4 или 5 (логический оператор "?". Статья на сайте Microsoft: https://cutt.ly/6ykLaTQ)
        {
            while (Variable.bunnyhop_is == true)
            {
                if (GetAsyncKeyState(32) != 0)
                {
                    Inject.mem.Write(Inject.client_dll + signatures.dwForceJump, Flags() ? 4 : 5);
                }
                Thread.Sleep(50);
            }
        }
        private static bool Flags() //на земле или в полёте персонаж и ответ основе
        {
            int LocalPlayer = Inject.mem.Read<int>(Inject.client_dll + signatures.dwLocalPlayer);
            int Flags = Inject.mem.Read<int>(LocalPlayer + netvars.m_fFlags);
            if (Flags == 256)
                return true;
            else if (Flags == 262)
                return true;
            else
                return false;
        }
    }
}
