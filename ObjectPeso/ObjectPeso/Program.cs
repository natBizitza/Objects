using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPeso
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso p1 = new Peso();
            Console.WriteLine(p1.GetPeso(10));
            Console.ReadLine();
        }
    }
}
