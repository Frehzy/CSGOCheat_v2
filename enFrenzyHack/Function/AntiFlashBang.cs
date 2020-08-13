using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System.Threading;

namespace enFrenzyHack.Function
{
    class AntiFlashBang
    {
        public static void ToAntiFlash()
        {
            int Player = Inject.mem.Read<int>(Inject.client_dll + signatures.dwLocalPlayer); //находим localplayer
            int Flash; //в Cheat Engine в смещениях можете ввести flashmaxAlpha и найдёте значение
            while (Variable.antiflash_is == true)
            {
                Flash = Inject.mem.Read<int>(Player + netvars.m_flFlashMaxAlpha);
                if (Flash > 1)
                {
                    Inject.mem.Write<int>(Player + netvars.m_flFlashMaxAlpha, 0);
                }
                Thread.Sleep(1);
            }
            Inject.mem.Write<int>(Player + netvars.m_flFlashMaxAlpha, Variable.backupflash);
            //проверка ниже на случай, если не получилось нормально присвоить значение предыдущему и оно всё ещё равно 0
            if ((Player + netvars.m_flFlashMaxAlpha) == 0)
                Inject.mem.Write<int>(Player + netvars.m_flFlashMaxAlpha, 1132396544);
        }
    }
}
