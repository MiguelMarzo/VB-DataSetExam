namespace CapaPresentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPedidosCliente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTopVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPedidosCliente
            // 
            this.btnPedidosCliente.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidosCliente.Location = new System.Drawing.Point(111, 143);
            this.btnPedidosCliente.Name = "btnPedidosCliente";
            this.btnPedidosCliente.Size = new System.Drawing.Size(194, 128);
            this.btnPedidosCliente.TabIndex = 0;
            this.btnPedidosCliente.Text = "Pedidos de un cliente";
            this.btnPedidosCliente.UseVisualStyleBackColor = true;
            this.btnPedidosCliente.Click += new System.EventHandler(this.btnPedidosCliente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 68);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Almacen";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 128);
            this.button1.TabIndex = 2;
            this.button1.Text = "Datos de un pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTopVentas
            // 
            this.btnTopVentas.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopVentas.Location = new System.Drawing.Point(263, 317);
            this.btnTopVentas.Name = "btnTopVentas";
            this.btnTopVentas.Size = new System.Drawing.Size(194, 128);
            this.btnTopVentas.TabIndex = 3;
            this.btnTopVentas.Text = "Top Ventas";
            this.btnTopVentas.UseVisualStyleBackColor = true;
            this.btnTopVentas.Click += new System.EventHandler(this.btnTopVentas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 512);
            this.Controls.Add(this.btnTopVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPedidosCliente);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedidosCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTopVentas;
    }
}

