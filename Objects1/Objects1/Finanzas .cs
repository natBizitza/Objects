using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{
    class Finanzas
    {
        private double dinero;
        private double exchangeRate;


        //constructors

        public Finanzas()
        {
            this.exchangeRate = 0.92;
        }

        public Finanzas(double exchangeRate)
        {
            this.exchangeRate = exchangeRate;
        }
        //métodos get y set
        //public double GetDinero()
        //{
        //    return dinero;
        //}
        //public void SetDinero(double dinero)
        //{
        //    this.dinero = dinero;
        //}

        //methods eurosToDolares
        public double EurosToDollars(double cantidad)
        {
           return cantidad* exchangeRate;
        }
        public double DollarsToEuros(double cantidad)
        {
            return cantidad / exchangeRate;
        }
    }
}
