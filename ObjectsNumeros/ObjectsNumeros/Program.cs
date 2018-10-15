using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero();
            Console.WriteLine("The sum is " + n1.SumIt(10,12));
            Console.WriteLine("The remainder is " + n1.Remainder(10,12));
            Console.WriteLine("The value is " + n1.getValor(10));
            Console.WriteLine("The double is " + n1.getDouble(10));
            Console.WriteLine("The trible is " + n1.getTriple(10));
            Console.WriteLine("The new value is " + n1.setNumero(10, 100));


            Console.ReadLine();
        }
    }
}
