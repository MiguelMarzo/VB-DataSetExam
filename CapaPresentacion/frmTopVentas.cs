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
    public partial class frmTopVentas : Form
    {
        Negocio _negocio = new Negocio();
        private List<Producto> topProductos;
        public frmTopVentas()
        {
            InitializeComponent();
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            if (!int.TryParse(txtCuantos.Text, out cantidad))
            {
                MessageBox.Show("Debes introducir una cantidad correcta");
                return;
            }
            topProductos = _negocio.DevolverTopVentas(cantidad);
            dgvTopVentas.DataSource = topProductos.Select(o => new
            {
                idProducto = o.id,
                NombreProducto = o.nombreProducto,
                NombreProveedor = o.nombreProveedor,
                NombreCategoría = o.nombreCategoria,
                PrecioUnidad = o.precioUnidad,
                UnidadesEnExistencia = o.unidadesEnExistencia,
                Suspendido = o.suspendido,
                TotalPedidos = o.cantidadPedidos
            }).ToList();
        }
    }
}
