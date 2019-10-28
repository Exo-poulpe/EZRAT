using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRATServer
{
    public partial class FileBrowser : Form
    {

        public enum FileType : int
        {
            File = 1,
            Folder = 2,
        }

        public FileBrowser()
        {
            InitializeComponent();
        }

        public void Update(string[] list, FileType type)
        {

        }

        public void Update(List<string> list, FileType type)
        {

        }

        public void Update(string list, char separator1 = '¦', char separator2 = '|')
        {
            ResetAll();
            // Tarte.cs¦File|Poulpe.cs¦File|
            StringBuilder sb = new StringBuilder(list);
            string name = string.Empty;
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == separator1)
                {
                    if (sb[i+1] == '1')
                    {
                        AddFileOrFolder(name, FileType.File);
                        name = string.Empty;
                        i += 3;
                    }
                    else
                    {
                        AddFileOrFolder(name, FileType.Folder);
                        name = string.Empty;
                        i += 3;
                    }
                }
                if (i <= sb.Length-1)
                {
                    name += sb[i].ToString();
                }
            }
        }

        private void AddFileOrFolder(string name, FileType type)
        {
            if (name.StartsWith("¦"))
            {
                name = name.Substring(3);
            }
            if (lstFiles.InvokeRequired)
                lstFiles.Invoke(new MethodInvoker(() => lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString() }))));
            else
                lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString() }));
        }

        private void ResetAll()
        {
            lstFiles.Items.Clear();
        }
    }
}
