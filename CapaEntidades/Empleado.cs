using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Empleado : IEquatable<Empleado>
    {
        public int id { get; set; }
        public String apellidos { get; set; }
        public String nombre { get; set; }
        public String cargo { get; set; }
        public String telefono { get; set; }

        public bool Equals(Empleado other)
        {
            if (other == null)
                return false;

            if (this.id == other.id)
                return true;
            else
                return false;
        }
    }
}
