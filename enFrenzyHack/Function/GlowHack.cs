using enFrenzyHack.BeforeInject;
using enFrenzyHack.Helper;
using System.Threading;

namespace enFrenzyHack.Function
{
    class GlowHack
    {
        public static void ToGlow() //glow
        {
            while (Variable.glow_is == true)
            {
                wint LocalPlayer = Inject.mem.Read<int>(Inject.client_dll + signatures.dwLocalPlayer);
                int PlayerTeam = Inject.mem.Read<int>(LocalPlayer + netvars.m_iTeamNum);
                for (int i = 0; i < 64; i++)
                {
                    int EntityList = Inject.mem.Read<int>(Inject.client_dll + signatures.dwEntityList + i * Offsets.dwEntityListDistance);
                    int EntityTeam = Inject.mem.Read<int>(EntityList + netvars.m_iTeamNum);
                    if (EntityTeam != 0 && EntityTeam != PlayerTeam)
                    {
                        int GlowIndex = Inject.mem.Read<int>(EntityList + netvars.m_iGlowIndex);
                        float HP = Inject.mem.Read<int>(EntityList + netvars.m_iHealth);
                        DrawEntityHP(GlowIndex, HP);
                    }
                }
                Thread.Sleep(Variable.Glow_Update);
            }
        }
        public static void DrawEntityHP(int GlowIndex, float HP) //рисуем обводку в зависимости от хп
        {
            int GlowObject = Inject.mem.Read<int>(Inject.client_dll + signatures.dwGlowObjectManager);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 4, 1 - HP / 100f);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 8, HP / 100f);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 12, 0 / 100f);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 0x10, 255 / 100f);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 0x24, true);
            Inject.mem.Write(GlowObject + (GlowIndex * 0x38) + 0x25, false);
        }
    }
}
