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
    public partial class ProcessViewer : Form
    {

        private Server _baseWindows;

        public Server BaseWindows
        {
            get { return _baseWindows; }
            set { _baseWindows = value; }
        }

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        const string STATUS_TEXT = "Number of process : ";
        public ProcessViewer(Server parent,int id)
        {
            this.BaseWindows = parent;
            this.Id = id;
            InitializeComponent();
            
        }


        public void UpdateData(string[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                string pid = data[i].Substring(data[i].LastIndexOf('¦') + 1);
                string name = data[i].Substring(0,data[i].LastIndexOf('¦'));
                this.lstProcess.Invoke(new MethodInvoker(() => { this.lstProcess.Items.Add(new ListViewItem(new string[] { name, pid })); })); 
            }
            this.lblStatus.Text = STATUS_TEXT + data.Length;
            this.lstProcess.Invoke(new MethodInvoker(() => this.lstProcess.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)));

            this.lstProcess.Invoke(new MethodInvoker(() => this.lstProcess.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)));
        }
    }
}
