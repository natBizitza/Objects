using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finanzas f1 = new Finanzas();
            Console.WriteLine("10 Euros son " + f1.EurosToDollars(10) + " dolares");
            Console.WriteLine("10 Dolares son " + f1.DollarsToEuros(10) + " euros");
            Console.ReadLine();
        }
    }
}
