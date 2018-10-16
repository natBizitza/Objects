using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCoche
{
    class Coche
    {
        public string Marca { get; set; } = "ferrri";
        public string Modelo { get; set; } = "panda";
        private double km, litros, avSpeed;
        //private double fuel;

        // default parameters. If you leave it empty all the parameters will be '0' be default 
        public Coche()
        {
            km = 60;
            litros = 100;
            avSpeed = 300;
        }

        public Coche(string marca, string modelo, double km, double litros, double avSpeed /*double fuel*/)
        {
            Marca = marca;
            Modelo = modelo;
            this.km = km;
            this.litros = litros;
            this.avSpeed = avSpeed;
            //this.fuel = fuel;

        }
        //Implements methods to get and set the value of the attributes, as well as a 
        //Get/Set methods


        // other methods

        //to show all data
        public string MostrarDatos()
        {
            return $"Coche con marca {Marca} y modelo {Modelo} for distance {km} km and with average speed of {avSpeed} km/h. It consumes {litros } liters average for fuel price {ConsumoEuros()}.";
        }
        //- getTiempo.Indicará el tiempo empleado en realizar el viaje.
        public double GetTiempo(double km, double avSpeed) => km / avSpeed;

        //– consumoMedio.Consumo medio del vehículo (en litros cada 100 kilómetros).
        public double ConsumoMedio() => litros / 100;

        //– consumoEuros.Consumo medio del vehículo(en euros cada 100 kilómetros).
        public double ConsumoEuros()
        {
            Console.WriteLine("Please, choose your type of fuel.");
            //Gasolina 95: 1.14 euros
            //Gasolina 98: 1.25 euros
            //Diesel: 1.04 euros


            Console.WriteLine("1  - Gasolina 95");
            Console.WriteLine("2  - Gasolina 98");
            Console.WriteLine("3  - Disel");

            int fuelTypeNumber;
            while (!int.TryParse(Console.ReadLine(), out fuelTypeNumber)) ;
            bool success = Enum.TryParse(fuelTypeNumber.ToString(), out EFuelType fuelType);
            if (!success) Console.WriteLine("Cannot cast value to FuelType enumerator.");

            double fuelPrice = GetFuelPriceByLiter(fuelType) * ConsumoMedio();
            return fuelPrice / 100;
        }



        private double GetFuelPriceByLiter(EFuelType fuelType)
        {
            switch (fuelType)
            {
                case EFuelType.Gasolina_95: return 1.14;
                case EFuelType.Gasolina_98: return 1.25;
                case EFuelType.Disel: return 1.04;
                default: throw new ArgumentException("unknown fuel type ");
            }
        }
    }
    enum EFuelType
    {
        Gasolina_95= 1,
        Gasolina_98 = 2,
        Disel = 3
    }
}
