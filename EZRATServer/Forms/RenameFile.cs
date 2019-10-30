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
    public partial class RenameFile : Form
    {
        private string _fileName;
        private string _pathFull;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public RenameFile(string path)
        {
            InitializeComponent();
            _pathFull = path;
            this.tbxName.Text = path.Substring(path.LastIndexOf('\\') + 1);
            this.btnValidate.Click += ValidateName;
        }

        private void ValidateName(object sender,EventArgs e)
        {
            this.FileName = _pathFull.Substring(0, _pathFull.LastIndexOf('\\') + 1) + tbxName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
