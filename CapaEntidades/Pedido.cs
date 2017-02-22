using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades 
{
    public class Pedido : IEquatable<Pedido>
    {
        public int numPedido { get; set; }
        public String idCliente { get; set; }
        public int idEmpleado { get; set; }
        public String nombreEmpleado { get; set; }
        public DateTime fechaPedido { get; set; }
        public DateTime fechaEntrega { get; set; }

        public Pedido(int numPedido, String idCliente, int idEmpleado, String nombreEmpleado, DateTime fechaPedido, DateTime fechaEntrega)
        {
            this.numPedido = numPedido;
            this.idCliente = idCliente;
            this.idEmpleado = idEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.fechaPedido = fechaPedido;
            this.fechaEntrega = fechaEntrega;
        }

        public bool Equals(Pedido other)
        {
            if (other == null)
                return false;

            if (this.numPedido == other.numPedido)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return numPedido.ToString();
        }
    }
}
