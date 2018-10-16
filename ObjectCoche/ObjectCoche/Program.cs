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
            var c1 = new Coche
            {
                Marca = "ferrari",
                Modelo = "testarrosa"
            };
            Console.WriteLine($"Your ride time is {c1.GetTiempo(30, 10)} km/h.");
            Console.WriteLine($"You consume {c1.ConsumoMedio() } liters per 100 km.");
            Console.WriteLine($"You spend on fuel {c1.ConsumoEuros()} euros per 100 km.");
            Console.WriteLine(c1.MostrarDatos());

            Coche c2 = new Coche("seat", "panda", 59, 19, 40);
            Console.WriteLine(c2.MostrarDatos());

            Console.ReadLine();
        }
    }
}
