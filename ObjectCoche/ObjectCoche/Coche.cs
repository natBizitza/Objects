using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoche
{
    class Coche
    {
        private string marca;
        private string modelo;

        public Coche()
        {

        }

        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        //Implements methods to get and set the value of the attributes, as well as a 
        //method to display all the information.

        public string GetMarca()
        {
            return this.marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string AllInfo()
        {
            return  "Coche con marca " + this.marca + " y modelo " + this.modelo;
        }
    }
}
