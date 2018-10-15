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
        private int kms;
        private int litros;
        private int avSpeed;
        private string fuel;

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
        //- getTiempo.Indicará el tiempo empleado en realizar el viaje.
        //– consumoMedio.Consumo medio del vehículo (en litros cada 100 kilómetros).
        //– consumoEuros.Consumo medio del vehículo(en euros cada 100 kilómetros).

    }
}
