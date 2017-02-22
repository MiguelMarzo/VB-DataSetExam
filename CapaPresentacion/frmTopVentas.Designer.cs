namespace CapaPresentacion
{
    partial class frmTopVentas
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
            this.dgvTopVentas = new System.Windows.Forms.DataGridView();
            this.txtCuantos = new System.Windows.Forms.TextBox();
            this.lblCuantos = new System.Windows.Forms.Label();
            this.btnMostrarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(329, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 70);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Top Ventas";
            // 
            // dgvTopVentas
            // 
            this.dgvTopVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopVentas.Location = new System.Drawing.Point(12, 197);
            this.dgvTopVentas.Name = "dgvTopVentas";
            this.dgvTopVentas.RowTemplate.Height = 24;
            this.dgvTopVentas.Size = new System.Drawing.Size(1099, 440);
            this.dgvTopVentas.TabIndex = 15;
            // 
            // txtCuantos
            // 
            this.txtCuantos.Location = new System.Drawing.Point(417, 127);
            this.txtCuantos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuantos.Name = "txtCuantos";
            this.txtCuantos.Size = new System.Drawing.Size(124, 22);
            this.txtCuantos.TabIndex = 17;
            // 
            // lblCuantos
            // 
            this.lblCuantos.AutoSize = true;
            this.lblCuantos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCuantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuantos.Location = new System.Drawing.Point(148, 127);
            this.lblCuantos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuantos.Name = "lblCuantos";
            this.lblCuantos.Size = new System.Drawing.Size(200, 22);
            this.lblCuantos.TabIndex = 16;
            this.lblCuantos.Text = "¿Cuántos más vendidos?";
            // 
            // btnMostrarPedido
            // 
            this.btnMostrarPedido.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPedido.Location = new System.Drawing.Point(611, 115);
            this.btnMostrarPedido.Name = "btnMostrarPedido";
            this.btnMostrarPedido.Size = new System.Drawing.Size(402, 42);
            this.btnMostrarPedido.TabIndex = 18;
            this.btnMostrarPedido.Text = "Productos no suspendidos más vendidos";
            this.btnMostrarPedido.UseVisualStyleBackColor = true;
            this.btnMostrarPedido.Click += new System.EventHandler(this.btnMostrarPedido_Click);
            // 
            // frmTopVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 649);
            this.Controls.Add(this.btnMostrarPedido);
            this.Controls.Add(this.txtCuantos);
            this.Controls.Add(this.lblCuantos);
            this.Controls.Add(this.dgvTopVentas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmTopVentas";
            this.Text = "frmTopVentas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvTopVentas;
        private System.Windows.Forms.TextBox txtCuantos;
        private System.Windows.Forms.Label lblCuantos;
        private System.Windows.Forms.Button btnMostrarPedido;
    }
}