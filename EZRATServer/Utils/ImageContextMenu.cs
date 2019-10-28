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
            this.CreateControl();
            this.Items.Add(menuFileBrowser);
            this.Items.Add(menuChat);
        }
    }
}
