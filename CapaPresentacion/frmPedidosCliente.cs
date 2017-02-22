using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmPedidosCliente : Form
    {
        Negocio _negocio = new Negocio();
        private List<Cliente> clientes;
        private List<Pedido> pedidos;
        public frmPedidosCliente()
        {
            InitializeComponent();
        }
        private void frmPedidosCliente_Load(object sender, EventArgs e)
        {
            clientes = _negocio.DevolverClientes();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "nombreCompañia";
        }
        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = (Cliente) cmbClientes.SelectedItem;
            pedidos = _negocio.DevolverPedidosPorCliente(clienteSeleccionado.id);
            if (pedidos.Count == 0)
            {
                MessageBox.Show("El cliente " + clienteSeleccionado.nombreCompañia + " no tiene pedidos");
                return;
            }
            dgvPedidosCliente.DataSource = pedidos.Select(o => new
            { Pedido = o.numPedido, Empleado = o.nombreEmpleado, Fecha_Pedido = o.fechaPedido, Fecha_Entrega = o.fechaEntrega }).ToList();

        }
    }
}
