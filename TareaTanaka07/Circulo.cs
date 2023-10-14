using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka07
{
    internal class Circulo
    {
        float r;
        public Circulo(float r)
        {
            this.r = r;
        }
        public float CalcularArea()
        {
            return (3.14f * (r * r)) / 2;
        }
    }
}
