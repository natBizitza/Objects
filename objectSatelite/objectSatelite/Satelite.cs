using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectSatelite
{
    public class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;
        private double desplazamiento;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }

        public void SetPosicion(double m, double p, double d)
        {
            this.meridiano = m;
            this.paralelo = p;
            this.distancia_tierra = d;
        }

        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + " Meridiano "+meridiano+" a una distancia de la tierra de "+distancia_tierra+" Kilómetros");
        }

        //Método void VariaAltura(double desplazamiento)
        public void VariaAltura(double dsp)
        {
            this.desplazamiento +=  dsp;
        }
        //Método boolean EnOrbita()
        public bool EnOrbita(bool enOrbita)
        {
            return distancia_tierra > 0;
            
        }
        //Método void VariaPosicion(double variap, double variam)
        public void VariaPosicion(double variap, double variam)
        {
            this.meridiano += variam;
            this.paralelo += variap;
        }
    }
}
