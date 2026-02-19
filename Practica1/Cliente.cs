using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Cliente
    {
        private string nombre;
        private string CUIT;
        private string telefono;
        private string tc;

        public Cliente(string nombre, string cuit, string telefono, string tc)
        {
            this.nombre = nombre;
            this.CUIT = cuit;
            this.telefono = telefono;
            this.tc = tc;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nCUIT: {CUIT}\nTelefono: {telefono}\nTipo: {tc}";
        }
    }
}
