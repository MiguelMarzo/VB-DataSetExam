using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente : IEquatable<Cliente>
    {
        public String id { get; set; }
        public String nombreCompañia { get; set; }
        public String nombreContacto { get; set; }
        public String telefono { get; set; }

        public Cliente(String id, String nombreCompañia, String nombreContacto, String telefono)
        {
            this.id = id;
            this.nombreCompañia = nombreCompañia;
            this.nombreContacto = nombreContacto;
            this.telefono = telefono;
        }
        public bool Equals(Cliente other)
        {
            if (other == null)
                return false;

            if (this.id.Equals(other.id))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return nombreContacto.ToString();
        }
    }
}
