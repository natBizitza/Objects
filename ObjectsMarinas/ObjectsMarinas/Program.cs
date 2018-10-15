using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsMarinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Marinas m1 = new Marinas();

            Console.WriteLine("100 nautical miles is " + m1.MillasAMetros(100) + " meters and " + m1.MillasAKilometros(100) + " km.");
            Console.ReadLine();
        }
    }
}
