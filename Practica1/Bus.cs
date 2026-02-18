using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    [Serializable]
    internal class Bus : Transporte
    {
        private string estrellas;
        

        public Bus(string destino, double precio, string patente, string estrellas) : base(destino, precio, patente)
        {
            this.destino = destino;
            this.preciobase = precio;
            this.patente = patente;
            this.estrellas = estrellas;
        }
        public override double PrecioFinal()
        {
            return preciobase + (preciobase * 0.115) + (preciobase * .30);
        }

        public override string ToString()
        {
            return "Bus: " + "Patente: " + patente;
        }
    }
}
