using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPeso
{
    class Peso
    {
        private double pesoKg;
        private string measure;
        //Li, Oz, P, K, G, Q;

        //constructors
        public Peso()
        {

        }
        public Peso(double pesoKg, string measure)
        {

        }

        public double GetPounds(double pesoKg)
        {
            return pesoKg / 0.453;
        }

        public double GetBollion(double pesoKg)
        {
            return pesoKg / 14.59;
        }

        public double GetPeso (double peso)
        {
            Console.WriteLine("1 - Lb");
            Console.WriteLine("2 - Li");
            Console.WriteLine("3 - Oz");
            Console.WriteLine("4 - P");
            Console.WriteLine("5 - K");
            Console.WriteLine("6- G");
            Console.WriteLine("7 - Q");

            Console.WriteLine("Choose one measure.");
            int measure = Convert.ToInt32(Console.ReadLine());
            //1 Libra = 16 onzas = 453 gramos.
            //1 Lingote = 32,17 libras = 14,59 kg.
            //1 Onza = 0,0625 libras = 28,35 gramos.
            //1 Penique = 0,05 onzas = 1,55 gramos.
            //1 Quintal = 100 libras = 43,3 kg.


            switch (measure) {
                case 1:
                    return peso/ 0.453;
                case 2:
                    return peso / 14.59;
                case 3:
                    return peso / 0.00153;
                case 4:
                    return peso / 0.02835;
                case 5:
                    return peso;
                case 6:
                    return peso*1000;
                case 7:
                    return peso/43.3;
            }
            return peso;
        }
    }
}
