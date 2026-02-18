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

        protected Transporte(string destino, double precio, string patente)
        {
            this.destino = destino;
            this.preciobase = precio;
            this.patente = patente;
        }

        protected string Destino { get { return destino; } }

        public abstract double PrecioFinal();
    }
}
