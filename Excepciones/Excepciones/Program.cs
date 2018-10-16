using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = 5 / Convert.ToInt32(Console.ReadLine());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Has dividido un numero entre cero");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            catch(System.FormatException ex)
            {
                Console.WriteLine("Has introducido una letra en vez un numero");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                //for ex conexion.close();
            }
           
            
            
        }
    }
}
