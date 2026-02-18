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
        private string NroIdentificacion;

        public Avion(string destino, double precio, string NroIden) : base(destino, precio, NroIden)
        {
            this.destino = destino;
            this.preciobase = precio;
            this.patente = NroIden;
         
        }
        public override double PrecioFinal()
        {
            return preciobase + (preciobase*0.21) + (preciobase *.30);
        }

        public override string ToString()
        {
            return "Avion: " + "Ident: "+patente;
        }

    }
}
