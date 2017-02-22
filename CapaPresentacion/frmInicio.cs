using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnPedidosCliente_Click(object sender, EventArgs e)
        {
            frmPedidosCliente pedidosCliente = new frmPedidosCliente();
            pedidosCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDatosDeUnPedido datosPedido = new frmDatosDeUnPedido();
            datosPedido.Show();
        }

        private void btnTopVentas_Click(object sender, EventArgs e)
        {
            frmTopVentas topVentas = new frmTopVentas();
            topVentas.Show();
        }
    }
}
