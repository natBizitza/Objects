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
        private double km;
        private double litros;
        private double avSpeed;
        private double fuel;

        public Coche()
        {
            this.marca = "ferrri";
            this.modelo = "panda";
            this.km = 60;
            this.litros = 100;
            this.avSpeed = 300;
            this.fuel = 500;
        }

        public Coche(string marca, string modelo, double km, double litros, double avSpeed, double fuel)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.km = km; 
            this.litros = litros;
            this.avSpeed = avSpeed;
            this.fuel = fuel;

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
        public double GetTiempo(double km, double avSpeed)
        {
            return km / avSpeed;
        }
        //– consumoMedio.Consumo medio del vehículo (en litros cada 100 kilómetros).
        public double consumoMedio(double litros)
        {
            return litros / 100;
        }
        //– consumoEuros.Consumo medio del vehículo(en euros cada 100 kilómetros).
        public double consumoEuros(double fuel)
        {
            return fuel / 100;
        }

    }
}
