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
       
        protected Cannonball() : 
            base()
        {
        }
        public Cannonball(int x, int y, int mass, double angle, double angleV) :
            base(x,y,mass,angle, angleV)
        {
        }
    }
}
//air density kg/m3 = 1.2754
//
