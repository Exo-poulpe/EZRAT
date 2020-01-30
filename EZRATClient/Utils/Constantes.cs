using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EZRATClient.Utils
{
    public static class Constantes
    {
        private const int _SW_HIDE = 0;
        private const int _SW_SHOW = 5;


        private static string _ip = "192.168.1.112";
        private static int _port = 1234;
        private static int _screenShotSpeed = 100;
        private static string _version = "0.1.2.0";
        private static string _encryptKey = "POULPE212123542345235";
        private static string _separator = "|";
        private static string _special_Separator = "¦";
        private static Thread _spy;

        public static string Separator { get => _separator; }
        public static char SeparatorChar { get => _separator.ToCharArray()[0]; }
        public static string Special_Separator { get => _special_Separator; }
        public static char Special_SeparatorChar { get => _special_Separator.ToCharArray()[0]; }

        public static string Ip { get => _ip; set => _ip = value; }
        public static int Port { get => _port; set => _port = value; }
        public static string Version { get => _version; set => _version = value; }
        public static int SW_HIDE => _SW_HIDE;
        public static int SW_SHOW => _SW_SHOW;
        public static string EncryptKey { get => _encryptKey; }
        public static Thread Spy { get => _spy; set => _spy = value; }
        public static int ScreenShotSpeed { get => _screenShotSpeed; }
    }
}
