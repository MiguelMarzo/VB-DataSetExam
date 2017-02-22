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
    public partial class frmDatosDeUnPedido : Form
    {
        Negocio _negocio = new Negocio();
        private List<DetallesPedido> detallesPedido;
        public frmDatosDeUnPedido()
        {
            InitializeComponent();
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            int numPedido = 0;
            if (!int.TryParse(txtNumeroPedido.Text, out numPedido))
            {
                MessageBox.Show("Debes introducir un número de pedido correcto");
                return;
            }
            detallesPedido = _negocio.DevolverDatosDePedido(numPedido);
            if (detallesPedido.Count == 0)
            {
                MessageBox.Show("No se ha encontrado un pedido con ese número");
                return;
            }
            lblNombreCompañia.Text = detallesPedido[0].nombreCompañia;
            lblNombreEmpleado.Text = detallesPedido[0].nombreEmpleado;
            float total = 0;
            foreach (DetallesPedido detalles in detallesPedido)
            {
                total += detalles.cantidad * (float) detalles.precioUnidad -  detalles.cantidad * (float) detalles.precioUnidad * detalles.descuento / 100;
            }
            lblTotal.Text = total.ToString();
            dgvPedidosCliente.DataSource = detallesPedido.Select(o => new
            { idProducto = o.idProducto, NombreProducto = o.nombreProducto, PrecioUnidad = o.precioUnidad,
                Cantidad = o.cantidad, Descuento = o.descuento }).ToList();
        }
    }
}
