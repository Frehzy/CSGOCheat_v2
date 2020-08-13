using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System.Threading;

namespace enFrenzyHack.Function
{
    class FOVHack
    {
        public static void FOVChanger()
        {
            int namedurself = Inject.mem.Read<int>(Inject.client_dll + signatures.dwLocalPlayer);
            while (Variable.fovhack_is == 1)
            {
                int isScoped = Inject.mem.Read<int>(namedurself + netvars.m_bIsScoped);
                if (isScoped == 0) //проверка на то, находится ли игрок в прицеле
                    Inject.mem.Write(namedurself + netvars.m_iFOV, Variable.fov);
                Thread.Sleep(1);
            }
        }

        //Я глубоко в душе не знаю, как обратно возвращать значение 90 и не влезать в цикл, чтоб визуально оно выглядело, как 90
        public static void FOVBackup()
        {
            int namedurself = Inject.mem.Read<int>(Inject.client_dll + signatures.dwLocalPlayer);
            int CurrentFOV = Inject.mem.Read<int>(namedurself + netvars.m_iFOV);
            while (Variable.fovhack_is == 2)
            {
                if (Inject.mem.Read<int>(namedurself + netvars.m_iFOV) != Variable.backupfov)
                {
                    Inject.mem.Write(namedurself + netvars.m_iFOV, Variable.backupfov);
                }

                int isScoped = Inject.mem.Read<int>(namedurself + netvars.m_bIsScoped);
                if (isScoped == 1)
                    Inject.mem.Write(namedurself + netvars.m_iFOV, 40);
                else
                    Inject.mem.Write(namedurself + netvars.m_iFOV, Variable.backupfov);
                if (Inject.mem.Read<int>(namedurself + netvars.m_iFOV) == 90)
                    Variable.fovhack_is = 0;

                Thread.Sleep(1);
            }
        }
    }
}
