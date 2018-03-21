using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWHD
{
    public partial class Cannonball : 
        Munitions
    {
        public Cannonball() : 
            base()
        {
        }
        public Cannonball(int x, int y, double angle) :
            base()
        {

        }
        override public void  moveObj()
        {

            X = X + VelX;
            if (Y == 150)
            {
                Y = Y + (VelY + gravity);
            }
            else if (Y < 50)
            {
                Y = Y + VelY;
            }
        }
    }
}
