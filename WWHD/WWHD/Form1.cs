using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHD
{
    public partial class Form1 : Form
    {
        Munitions round;
        protected Timer tmr;
        protected int x, y;
        public Form1()
        {
            x = 10;
            y = 50;
            tmr = new Timer();
            tmr.Interval = 17;
            tmr.Tick += Tmr_Tick;
            InitializeComponent();
        }

        private void Tmr_Tick(object sender, EventArgs e)// Timer 
        {
            x = x + 1;
            y = y + 1;
            Invalidate();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            tmr.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr.Stop();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            int imgHeight = (Properties.Resources.CannonBall.Height)/2;
            int xPic = x - (Properties.Resources.CannonBall.Height)/2;
            int yPic = (this.Height - y) - imgHeight;
            Graphics pic = e.Graphics;
            pic.Clear(Color.Bisque);
            pic.ResetTransform();
            pic.TranslateTransform(xPic, yPic);
            pic.DrawImage(Properties.Resources.CannonBall, new Point(0, 0));
        }
    }
}
