using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    [Serializable]
    internal class Sistema
    {
        private List<Ticket> tickets;

        public List<Ticket> Tickets { get { return tickets; } }

        public void GeneroTicket() { }
        
    }
}
