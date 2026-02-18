using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    [Serializable]
    internal class Ticket
    {
        private DateTime fecha;
        private double precioFinal;
        private string destino;
        private string transporte;
        private Cliente cliente;

        public Ticket()
        {
            fecha = DateTime.Now;
            precioFinal = 0;
            
        }

        public override string ToString()
        {
            return @"
                     ---------------------------------
                      Agencia de viajes Final PRG II
                     ---------------------------------
             ";
        }
    }
}
