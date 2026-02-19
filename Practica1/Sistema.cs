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
        public static int nroTicket;
        private List<Ticket> tickets;

        public List<Ticket> Tickets { get { return tickets; } }

        public void GeneroTicket(Cliente cliente, Transporte transporte) {
            Ticket ticket = new Ticket(transporte, cliente);
            tickets.Add(ticket);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sistema de Tickets:");
            foreach (var ticket in tickets)
            {
                sb.AppendLine(ticket.ToString());
                sb.AppendLine("---------------------------------");
            }
            return sb.ToString();
        }

        
    }
}
