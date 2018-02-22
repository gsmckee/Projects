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
        Cannonball round;// declare object of child class Cannonball

        //Property to handle changing image associated with selection from combo box.

        //public string ordShape;
        //protected string OrdShape// property to get combo box selection
        //{
        //    get
        //    {
        //        // check if there was a selection 
        //        return cbOrdList.SelectedText != null ? ordShape : null;
                
        //    }
        //    set
        //    {
        //        // check if there was a selection and set Bitmap to associated selection.
        //        if (cbOrdList.SelectedText != null)
        //        {
        //            objImg = (Bitmap)Properties.Resources.ResourceManager.GetObject(cbOrdList.GetItemText(cbOrdList.SelectedItem));
        //        }
        //        else objImg = null;
                    
        //    }
        //}
        protected Timer tmr;// used to apply movement

        // starting positon, velocity for direction, and acting gravitational pull.
        protected int x, y, velX, velY, angle; 

        public Bitmap objImg;// store .png to be referenced

        //Polynomial p;
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
            //x = x + 1;
            //y = y + 1;
            fireObject();
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


        //Display desired images and user interface elements.
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            int imgHeight = (Properties.Resources.CannonBall.Height) / 2;
            int imgWidth = (Properties.Resources.CannonBall.Width) / 2;
            int xPic = (int)x - (Properties.Resources.CannonBall.Height) / 2;
            int yPic = (int)(this.Height - y) - imgHeight;
            Graphics pic = e.Graphics;
            pic.Clear(Color.DarkSlateBlue);
            pic.ResetTransform();
            pic.TranslateTransform(xPic, yPic);
            pic.DrawImage(Properties.Resources.CannonBall, new Point(0, 0));
        }
        // Method to handle motion of object.
        protected void fireObject()
        {

            velX = x + 1;
            velY = y + 1;
            x = velX;
            y = velY;
            gravity();
        }
        
        //Gravity effect
        protected void gravity()
        {
            y = y + velY * tmr.Interval / 2;
        }

        // Take action on selected index of combo box.

        //private void cbOrdList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    default.selectedIndex(1);// set to selected text of combo box
        //}


            // Tie resource image to selected combo box string.
        //protected Image getImg(string s)
        //{
        //    Image img;
        //    switch (s)
        //    {
        //        case "Circular":
        //            img = Properties.Resources.CannonBall;
        //            break;
        //        case "Bullet":
        //            img = Properties.Resources.Projectile;
        //            break;
        //        case "Grenade":
        //            img = Properties.Resources.Grenade;
        //            break;
        //        case "Missile":
        //            img = Properties.Resources.Missile;
        //            break;
        //        case "Mortar":
        //            img = Properties.Resources.Mortar;
        //            break;
        //        case "Rocket":
        //            img = Properties.Resources.Rocket;
        //            break;
        //        default : img = null;
        //            break;  
        //    }
        //    return img;
        //}
    }
}
