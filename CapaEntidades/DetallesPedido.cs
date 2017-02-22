using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetallesPedido :IEquatable<DetallesPedido>
    {
        public int numPedido { get; set; }
        public String nombreCompañia { get; set; }
        public String nombreEmpleado { get; set; }
        public int idProducto { get; set; }
        public String nombreProducto { get; set; }
        public decimal precioUnidad { get; set; }
        public int cantidad { get; set; }
        public Single descuento { get; set; }

        public DetallesPedido(int numPedido, String nombreCompañia, String nombreEmpleado, int idProducto, String nombreProducto,
            decimal precioUnidad, int cantidad, Single descuento)
        {
            this.numPedido = numPedido;
            this.nombreCompañia = nombreCompañia;
            this.nombreEmpleado = nombreEmpleado;
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.precioUnidad = precioUnidad;
            this.cantidad = cantidad;
            this.descuento = descuento;
        }

        public bool Equals(DetallesPedido other)
        {
            if (other == null)
                return false;

            if (this.numPedido == other.numPedido && this.idProducto == other.idProducto)
                return true;
            else
                return false;
        }
    }
}
