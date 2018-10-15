using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectSatelite
{
    class Program
    {
        static void Main(string[] args)
        {
            Satelite s1 = new Satelite();

            s1.SetPosicion(10, 12, 20);
            s1.PrintPosicion();
            s1.VariaAltura(12);
            s1.EnOrbita(true);
            s1.VariaPosicion(11, 12);
  
            Console.ReadLine();
        }
    }
}
