using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System.Threading;

namespace enFrenzyHack.Function
{
    class RadarHack
    {
        public static void ToRadarHack()
        {
            while (Variable.radarhack_is == true)
            {
                for (int i = 0; i < 64; i++)
                {
                    int entity = Inject.mem.Read<int>(Inject.client_dll + signatures.dwEntityList + i * Offsets.dwEntityListDistance);
                    if (entity != null) //если значение на том месте, где должна быть инфа о игроке, не пустое, то значение bSpotted = true
                    {
                        Inject.mem.Write(entity + netvars.m_bSpotted, true);
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
