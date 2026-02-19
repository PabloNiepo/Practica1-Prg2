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
        private Cliente cliente;
        private Transporte transporte;
        /*private double precioFinal;
        private string destino;
        private string transporte;
        private Cliente cliente;*/

        public Ticket(Transporte transporte, Cliente cliente)
        {
            fecha = DateTime.Now;
            this.cliente = cliente;
            this.transporte = transporte;
            
        }

        public override string ToString()
        {
            return $@"---------------------------------
Agencia de viajes Final PRG II
---------------------------------

Fecha: {fecha}

Cliente:
{cliente}

Transporte: {transporte?.GetType().Name}
Precio final: {transporte?.PrecioFinal():C}
";
        }
    }
}
