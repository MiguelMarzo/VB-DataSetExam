namespace CapaPresentacion
{
    partial class frmDatosDeUnPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblNombreCompañiaCliente = new System.Windows.Forms.Label();
            this.lblNombreCompañia = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.btnMostrarPedido = new System.Windows.Forms.Button();
            this.dgvPedidosCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(567, 70);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Datos de un Pedido";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPedido.Location = new System.Drawing.Point(29, 107);
            this.lblNumeroPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(154, 22);
            this.lblNumeroPedido.TabIndex = 4;
            this.lblNumeroPedido.Text = "Número de Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(206, 102);
            this.txtNumeroPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(124, 27);
            this.txtNumeroPedido.TabIndex = 5;
            // 
            // lblNombreCompañiaCliente
            // 
            this.lblNombreCompañiaCliente.AutoSize = true;
            this.lblNombreCompañiaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreCompañiaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompañiaCliente.Location = new System.Drawing.Point(565, 102);
            this.lblNombreCompañiaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompañiaCliente.Name = "lblNombreCompañiaCliente";
            this.lblNombreCompañiaCliente.Size = new System.Drawing.Size(236, 22);
            this.lblNombreCompañiaCliente.TabIndex = 6;
            this.lblNombreCompañiaCliente.Text = "Nombre compañía del Cliente:";
            // 
            // lblNombreCompañia
            // 
            this.lblNombreCompañia.AutoSize = true;
            this.lblNombreCompañia.BackColor = System.Drawing.Color.LightGreen;
            this.lblNombreCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompañia.Location = new System.Drawing.Point(820, 104);
            this.lblNombreCompañia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompañia.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblNombreCompañia.Name = "lblNombreCompañia";
            this.lblNombreCompañia.Size = new System.Drawing.Size(200, 20);
            this.lblNombreCompañia.TabIndex = 7;
            this.lblNombreCompañia.Text = "Nombre";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.BackColor = System.Drawing.Color.LightGreen;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(202, 160);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEmpleado.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(200, 20);
            this.lblNombreEmpleado.TabIndex = 10;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(93, 158);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(90, 22);
            this.lblEmpleado.TabIndex = 9;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.LightGreen;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(820, 160);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.Location = new System.Drawing.Point(694, 158);
            this.lblTotalPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(107, 22);
            this.lblTotalPedido.TabIndex = 11;
            this.lblTotalPedido.Text = "Total pedido:";
            // 
            // btnMostrarPedido
            // 
            this.btnMostrarPedido.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPedido.Location = new System.Drawing.Point(251, 223);
            this.btnMostrarPedido.Name = "btnMostrarPedido";
            this.btnMostrarPedido.Size = new System.Drawing.Size(550, 72);
            this.btnMostrarPedido.TabIndex = 13;
            this.btnMostrarPedido.Text = "Mostrar pedido por nº pedido:";
            this.btnMostrarPedido.UseVisualStyleBackColor = true;
            this.btnMostrarPedido.Click += new System.EventHandler(this.btnMostrarPedido_Click);
            // 
            // dgvPedidosCliente
            // 
            this.dgvPedidosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosCliente.Location = new System.Drawing.Point(12, 313);
            this.dgvPedidosCliente.Name = "dgvPedidosCliente";
            this.dgvPedidosCliente.RowTemplate.Height = 24;
            this.dgvPedidosCliente.Size = new System.Drawing.Size(1052, 347);
            this.dgvPedidosCliente.TabIndex = 14;
            // 
            // frmDatosDeUnPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 672);
            this.Controls.Add(this.dgvPedidosCliente);
            this.Controls.Add(this.btnMostrarPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalPedido);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblNombreCompañia);
            this.Controls.Add(this.lblNombreCompañiaCliente);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosDeUnPedido";
            this.Text = "frmDatosDeUnPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblNombreCompañiaCliente;
        private System.Windows.Forms.Label lblNombreCompañia;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Button btnMostrarPedido;
        private System.Windows.Forms.DataGridView dgvPedidosCliente;
    }
}