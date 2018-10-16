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
        //private double fuel;

        public Coche()
        {
            this.marca = "ferrri";
            this.modelo = "panda";
            this.km = 60;
            this.litros = 100;
            this.avSpeed = 300;
            //this.fuel = 500;
        }

        public Coche(string marca, string modelo, double km, double litros, double avSpeed /*double fuel*/)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.km = km; 
            this.litros = litros;
            this.avSpeed = avSpeed;
            //this.fuel = fuel;

        }
        //Implements methods to get and set the value of the attributes, as well as a 
        //Get/Set methods

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

        // other methods
        public string MostrarDatos()
        {
            return  "Coche con marca " + this.marca + " y modelo " + this.modelo + " for distance " + km + " km and with average speed of " + avSpeed + " km/h. It consumes " + litros + " liters average for fuel price " + this.consumoEuros() + ".";
        }
        //- getTiempo.Indicará el tiempo empleado en realizar el viaje.
        public double GetTiempo(double km, double avSpeed)
        {
            return km / avSpeed;
        }
        //– consumoMedio.Consumo medio del vehículo (en litros cada 100 kilómetros).
        public double consumoMedio()
        {
            return this.litros / 100;
        }
        //– consumoEuros.Consumo medio del vehículo(en euros cada 100 kilómetros).
        public double consumoEuros()
        {
            Console.WriteLine("Please, choose your type of fuel.");
            //Gasolina 95: 1.14 euros
            //Gasolina 98: 1.25 euros
            //Diesel: 1.04 euros

            double fuelPrice;
            Console.WriteLine("1  - Gasolina 95");
            Console.WriteLine("2  - Gasolina 98");
            Console.WriteLine("3  - Disel");
            fuelPrice = Convert.ToInt32(Console.ReadLine());

            switch(fuelPrice)
            {
                case 1:
                    fuelPrice = 1.14 * this.litros;
                    break;
                case 2:
                    fuelPrice = 1.25 * this.litros;
                    break;
                case 3:
                    fuelPrice = 1.04 * this.litros;
                    break;
            }
            return fuelPrice / 100;
        }
    }
}
