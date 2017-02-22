using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto : IEquatable<Producto>
    {
        public int id { get; set; }
        public String nombreProducto { get; set; }
        public int idProveedor { get; set; }
        public int idCategoria { get; set; }
        public decimal precioUnidad { get; set; }
        public int unidadesEnExistencia { get; set; }
        public bool suspendido { get; set; }

        public Producto(int id, String nombreProducto, int idProveedor, int idCategoria, decimal precioUnidad, int unidadesEnExistencia, bool suspendido)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.idProveedor = idProveedor;
            this.idCategoria = idCategoria;
            this.precioUnidad = precioUnidad;
            this.unidadesEnExistencia = unidadesEnExistencia;
            this.suspendido = suspendido;
        }

        public bool Equals(Producto other)
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
