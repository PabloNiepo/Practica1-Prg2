using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    [Serializable]
    internal class Avion:Transporte
    {
        public override string Destino => throw new NotImplementedException();

        public Avion(string destino, double precio): base(destino, precio)
        {
            this.destino = destino;
            this.preciobase = precio;

        }
        public override double PrecioFinal()
        {
            return preciobase + (preciobase*0.21) + (preciobase *.30);
        }

        public override string ToString()
        {
            return "Avion: " + "Patente: "+patente;
        }

    }
}
