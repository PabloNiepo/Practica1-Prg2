using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    [Serializable]
    abstract class Transporte
    {
        protected double preciobase;
        protected string destino;
        protected string patente;

        protected Transporte(string destino, double precio)
        {
            this.destino = destino;
            this.preciobase = precio;
        }

        public abstract string Destino { get; }

        public abstract double PrecioFinal();

    }
}
