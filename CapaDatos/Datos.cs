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
        private ProductoTableAdapter daProducto;
        private DetallesPedidoTableAdapter daDetalles;
        private CategoriaTableAdapter daCategoria;
        private ProveedorTableAdapter daProveedor;

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

            daProducto = new DsAlmacenTableAdapters.ProductoTableAdapter();
            daProducto.Fill(dsAlmacen.Producto);

            daDetalles = new DsAlmacenTableAdapters.DetallesPedidoTableAdapter();
            daDetalles.Fill(dsAlmacen.DetallesPedido);

            daCategoria = new DsAlmacenTableAdapters.CategoriaTableAdapter();
            daCategoria.Fill(dsAlmacen.Categoria);

            daProveedor = new DsAlmacenTableAdapters.ProveedorTableAdapter();
            daProveedor.Fill(dsAlmacen.Proveedor);
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

        public List<DetallesPedido> DevolverDatosDePedido(int numeroPedido)
        {
            var productosPedido = from daDetalles in dsAlmacen.DetallesPedido
                                  where daDetalles.NumPedido == numeroPedido
                                  select new DetallesPedido(daDetalles.IdProducto,daDetalles.PedidoRow.ClienteRow.NombreCompañia,
                                  daDetalles.PedidoRow.EmpleadoRow.Nombre,daDetalles.IdProducto, daDetalles.ProductoRow.NombreProducto,
                                  daDetalles.PrecioUnidad, daDetalles.Cantidad, daDetalles.Descuento);
            return productosPedido.ToList(); ;
        }

        public List<Producto> DevolverTopVentas(int cantidad)
        {
            var topProductos = from daProducto in dsAlmacen.Producto
                               where daProducto.Suspendido == false
                               orderby daProducto.GetDetallesPedidoRows().Count() descending, daProducto.UnidadesEnExistencia descending                         
                               select new Producto(daProducto.Id, daProducto.NombreProducto, daProducto.IdProveedor, daProducto.ProveedorRow.NombreCompañia,
                               daProducto.IdCategoria, daProducto.CategoriaRow.NombreCategoria, daProducto.PrecioUnidad, daProducto.UnidadesEnExistencia, 
                               daProducto.Suspendido, daProducto.GetDetallesPedidoRows().Count());
            return topProductos.Take(cantidad).ToList();
        }
    }
}
