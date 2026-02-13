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
        public override string Destino => throw new NotImplementedException();

        public Bus(string destino, double precio) : base(destino, precio)
        {
            this.destino = destino;
            this.preciobase = precio;

        }
        public override double PrecioFinal()
        {
            return preciobase + (preciobase * 0.21) + (preciobase * .30);
        }

        public override string ToString()
        {
            return "Bus: " + "Patente: " + patente;
        }
    }
}
