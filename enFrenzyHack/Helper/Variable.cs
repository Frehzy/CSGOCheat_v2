using System;

namespace enFrenzyHack.Helper
{
    class Variable
    {
        //CHEATNAME
        public const string CheatName = "enFrenzyHack";

        //checkcsgo
        public static bool check = false;

        //esp
        public static float ESPThickness = 0.5f; //толщина линий
        public static float ESPBrightness = 0.5f; //яркость линий
        public static Int32 Red = 255;
        public static Int32 Green = 0;
        public static Int32 Blue = 0;
        public static int ESPBoostFPS = 0; //число, которое загоняется в Thread.Sleep()

        //glow
        public static bool glow_is = false;
        public static Int32 Glow_Update = 125; //скорость обновления. Чем больше число, тем больше ест фпс и тем меньше происходит миганий обводки

        //radarhack
        public static bool radarhack_is = false;

        //bunnyhop
        public static bool bunnyhop_is = false;

        //fov
        public static int fovhack_is = 0; //0 - выкл, 1 - вкл, 2 - перевод fov в 90
        public static int fov = 90;
        public static int backupfov = 90; //я хз, почему это не работает, когда отключаешь fovhack. Единственный способ - прицелиться через любой прицел, умереть и тп

        //antiflash
        public static bool antiflash_is = false;
        public static int backupflash; //сюда записывается изначальное значение "яркости" флешки на экране, чтобы потом обратно его записать после отключения функции

        //вкл/выкл формы чита
        public static int on_off = 0; //чётное - вкл, нечётное - выкл
    }
}
