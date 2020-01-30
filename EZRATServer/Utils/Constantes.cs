using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EZRATServer.Utils
{
    public static class Constantes
    {
        private static string _encryptKey = "POULPE212123542345235";
        private static int _screenShotSpeed = 1000;
        private static string _separator = "|";
        private static string _special_Separator = "¦";

        public static string EncryptKey { get => _encryptKey;}
        public static string Separator { get => _separator;}
        public static char SeparatorChar { get => _separator.ToCharArray()[0]; }
        public static string Special_Separator { get => _special_Separator; }
        public static char Special_SeparatorChar { get => _special_Separator.ToCharArray()[0]; }
        public static int ScreenShotSpeed { get => _screenShotSpeed; set => _screenShotSpeed = value; }
    }
}
