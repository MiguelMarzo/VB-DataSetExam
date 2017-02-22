using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class Negocio
    {
        private Datos _datos = new Datos();

        public List<Cliente> DevolverClientes()
        {
            return _datos.DevolverClientes();
        } 

        public List<Pedido> DevolverPedidosPorCliente(String idCliente)
        {
            return _datos.DevolverPedidosPorCliente(idCliente);
        }
    }
}
