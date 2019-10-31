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
    public partial class SystemDetails : Form
    {
        public SystemDetails()
        {
            InitializeComponent();
        }

        public SystemDetails(string[] data)
        {
            InitializeComponent();
            this.UpdateData(data);
        }

        public void UpdateData(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.lstInfos.Items.Add(data[i]);
            }
        }

        public void Clean()
        {
            this.lstInfos.Items.Clear();
        }
    }
}
