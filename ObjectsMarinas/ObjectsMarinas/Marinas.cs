using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsMarinas
{
    class Marinas
    {
        private double marinas;

        public Marinas()
        {
            
        }

        public double MillasAMetros(double marinas)
        {
           return marinas * 1852;
        }

        public double MillasAKilometros(double marinas)
        {
            return marinas * 1.852;
        }
    }
}
