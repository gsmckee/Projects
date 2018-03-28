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
        protected Timer tmr;// used to increment position of object

        // starting positon, velocity for direction, and angle.
        //protected int x, y, velX, velY, angle; 

        public Bitmap objImg;// store .png to be referenced
        
        public Form1()
        {
            
            round = new Cannonball(150, 100, 20, 0, 75);

            // Testing angular velocity
            //round.VelX = 0; round.VelY = 0;

            objImg = Properties.Resources.Rocket;
            tmr = new Timer();
            tmr.Interval = 16;
            tmr.Tick += Tmr_Tick;
            InitializeComponent();
            cbOrdList.SelectedIndex = 0;

            //Remove flicker from paint object.
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UserPaint, true);
            UpdateStyles();

            //Enforce form to fit full screen.
            this.WindowState = FormWindowState.Maximized;
        }

        private void Tmr_Tick(object sender, EventArgs e)// Timer 
        {
            
            round.moveObj(0.032f);
            float speed = (float)Math.Sqrt(round.VelX * round.VelX + round.VelY * round.VelY);
            Text = round.X.ToString("N1") + ", " + round.Y.ToString("N1") + ", Vel: " 
                + round.VelX.ToString("N1") + ", " + round.VelY.ToString("N1") + " Speed: " + speed.ToString("N1")
                + " Air Drag: " + round.ady.ToString("N1");
            
            Invalidate();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (round.VelX < 1 && round.VelY < 1)
            {
                parseUserInput();                
            }
            round.agy = -9.8f;
            tmr.Start();
        }

        private void btnEnterCoords_Click(object sender, EventArgs e)
        {
            parseUserInput();

        }

        private void parseUserInput()
        {
            bool usrY;
            bool usrX;

            round.VelX = 20;
            round.VelY = 40;

            usrX = float.TryParse(tbVelX.Text, out round.VelX);
            usrY = float.TryParse(tbVelY.Text, out round.VelY);
            if (usrX == false || usrY == false)
            {
                lblU_inputError.Visible = true;
                if (usrX == false && usrY == false)
                {
                    lblU_inputError.Text = "X, Y coords require whole integers.";
                }
                else if (usrX == false)
                {
                    lblU_inputError.Text = "X coords require whole integers.";
                    round.VelY = int.Parse(tbVelY.Text);
                    //round.VelY = int.Parse(tbVelY.Text);
                }
                else
                {
                    lblU_inputError.Text = "Y coords require whole integers.";
                    round.VelX = int.Parse(tbVelX.Text);
                    //round.VelX = int.Parse(tbVelX.Text);
                    //round.VelY = 900;
                }
            }
            else
            {
                round.VelX = float.Parse(tbVelX.Text);
                round.VelY = float.Parse(tbVelY.Text);
                //round.VelX = int.Parse(tbVelX.Text);
                //round.VelY = int.Parse(tbVelY.Text);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr.Stop();
        }


        //Display desired images and user interface elements.
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            int imgHeight = (objImg.Height) / 2;
            int imgWidth = (objImg.Width) / 2;
            int xPic = (int)round.X - imgWidth;
            int yPic = (int)(this.Height - 40 -round.Y) - imgHeight;
            Graphics pic = e.Graphics;
            pic.Clear(Color.Green);
            pic.ResetTransform();
            pic.TranslateTransform(round.X, this.Height - 40 - round.Y);
            pic.TranslateTransform(imgWidth, imgHeight);
            pic.RotateTransform((float)round.Angle);
            pic.TranslateTransform(-imgWidth, -imgHeight);
            pic.DrawImage(objImg, new Point(0, 0));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {            
            round.X = 10;
            round.Y = 0;
            round.VelX = 0;
            round.VelY = 0;
            round.agy = 0;
        }

        private void cbOrdList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //switch (cbOrdList.SelectedIndex.ToString())
            //{
            //    case "Circular":
            //        objImg = Properties.Resources.Standard1;
            //        break;
            //    case "Bullet":
            //        objImg = Properties.Resources.Projectile;
            //        break;
            //    case "Grenade":
            //        objImg = Properties.Resources.Grenade;
            //        break;
            //    case "Missile":
            //        objImg = Properties.Resources.Missile;
            //        break;
            //    case "Mortar":
            //        objImg = Properties.Resources.Mortar;
            //        break;
            //    case "Rocket":
            //        objImg = Properties.Resources.Rocket;
            //        break;
            //    default:
            //        objImg = null;
            //        break;
            //}

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
