using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traverse
{
    public class Projectile
    {
        protected int Mass, Velocity, Angle;
        public Projectile(int mass, int vel, int angle)
        {
            Mass = mass;
            Velocity = vel;
            Angle = angle;
        }

    }
}
