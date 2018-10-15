using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsNumeros
{
    class Numero
    {
        private int number;


        //default constructor
        public Numero()
        {
            number = 0;
        }

        public Numero(int number)
        {
           this.number = number;
        }

        //Método aniade que permite sumarle un número al valor interno.

        public int SumIt(int number, int newNum)
        {
            return number + newNum;
        }
        //Método resta que resta un número al valor interno.
        public int Remainder(int number, int newNum)
        {
            return newNum % number;
        }
        //Método getValor. Devuelve el valor interno.
        public int getValor(int number)
        {
            return number;
        }
        //Método getDoble. Devuelve el doble del valor interno.
        public int getDouble(int number)
        {
            return number * 2;
        }
        //Método getTriple. Devuelve el triple del valor interno.
        public int getTriple(int number)
        {
            return number *3;
        }
        //Método setNumero. Inicializa de nuevo el valor interno.
        public int setNumero(int number, int newNum)
        {
            return number = newNum;
        }
    }
}
