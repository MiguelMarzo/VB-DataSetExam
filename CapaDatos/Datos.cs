using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.DsAlmacenTableAdapters;
using CapaEntidades;

namespace CapaDatos
{
    public class Datos
    {
        private DsAlmacen dsAlmacen;
        private ClienteTableAdapter daCliente;
        private PedidoTableAdapter daPedido;
        private EmpleadoTableAdapter daEmpleado;

        public Datos()
        {
            CrearDataSetCompleto();
        }

        public void CrearDataSetCompleto()
        {
            dsAlmacen = new DsAlmacen();

            daCliente = new DsAlmacenTableAdapters.ClienteTableAdapter();
            daCliente.Fill(dsAlmacen.Cliente);

            daPedido = new DsAlmacenTableAdapters.PedidoTableAdapter();
            daPedido.Fill(dsAlmacen.Pedido);

            daEmpleado = new DsAlmacenTableAdapters.EmpleadoTableAdapter();
            daEmpleado.Fill(dsAlmacen.Empleado);
        }
        public List<Cliente> DevolverClientes()
        {
            var clientes = from daCliente in dsAlmacen.Cliente
                           orderby daCliente.NombreCompañia descending
                           select new Cliente(daCliente.Id, daCliente.NombreCompañia, daCliente.NombreContacto, daCliente.Telefono);
            return clientes.ToList();
        }

        public List<Pedido> DevolverPedidosPorCliente(String idCliente)
        {
            var pedidosCliente = from daPedido in dsAlmacen.Pedido
                                 where daPedido.IdCliente == idCliente
                                 select new Pedido(daPedido.NumPedido, daPedido.IdCliente, daPedido.IdEmpleado, daPedido.EmpleadoRow.Nombre,
                                                    daPedido.FechaPedido, daPedido.FechaEntrega);
            return pedidosCliente.ToList();
        }
    }
}
