using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoche
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche c1 = new Coche();
            c1.SetMarca("ferrari");
            c1.SetModelo("testarrosa");

            Console.WriteLine(c1.AllInfo());
            Coche c2 = new Coche("seat", "panda");
            Console.WriteLine(c2.AllInfo());

            Console.ReadLine();
        }
    }
}
