using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka07
{
    internal class Triángulo
    {
        float b;
        float h;
        public Triángulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public float CalcularArea()
        {
            return (b * h)/2;
        }
    }
}
