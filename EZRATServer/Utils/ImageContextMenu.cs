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
            ToolStripMenuItem menuProcess = new ToolStripMenuItem("Process Viewer",new Bitmap(Properties.Resources.process_100));
            ToolStripMenuItem menuScreenShot = new ToolStripMenuItem("ScreenShot",new Bitmap(Properties.Resources.screenShot_100));
            this.CreateControl();
            this.Items.Add(menuFileBrowser);
            this.Items.Add(menuChat);
            this.Items.Add(menuProcess);
            this.Items.Add(menuScreenShot);
        }
    }
}
