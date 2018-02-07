using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Equations
    {
        protected float a;
        protected float b;
        protected float c;
        protected float d;
        public float AreaSquare(float a)
        {
            this.a = a;
            float c = a * a;
            return c;
        }
        public float AreaRect(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = a * b;
            return c;
        }
        public float AreaTriangle(float a, float b)
        {
            this.a = a;
            this.b = b;
            float c = (a / 2) * b;
            return c;
        }
        public float AreaTrapezoid(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            float e = ((b+c)/2)*a;
            return e;
        }

    }
}
