namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class DetallePublicacion
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.GBDetalle = new System.Windows.Forms.GroupBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.txtRubros = new System.Windows.Forms.TextBox();
            this.txtTipoPublicacion = new System.Windows.Forms.TextBox();
            this.txtFechaFinalizacion = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.txtCodVisibilidad = new System.Windows.Forms.TextBox();
            this.txtEstadoPublicacion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtStockDisponible = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCodPublicacion = new System.Windows.Forms.TextBox();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.lblTipoPublicacion = new System.Windows.Forms.Label();
            this.lblEstadoPublicacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.lblVisibilidad = new System.Windows.Forms.Label();
            this.lblCodPublicacion = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(545, 315);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(359, 315);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 28);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // GBDetalle
            // 
            this.GBDetalle.Controls.Add(this.lblRubro);
            this.GBDetalle.Controls.Add(this.txtRubros);
            this.GBDetalle.Controls.Add(this.txtTipoPublicacion);
            this.GBDetalle.Controls.Add(this.txtFechaFinalizacion);
            this.GBDetalle.Controls.Add(this.txtStockInicial);
            this.GBDetalle.Controls.Add(this.txtCodVisibilidad);
            this.GBDetalle.Controls.Add(this.txtEstadoPublicacion);
            this.GBDetalle.Controls.Add(this.txtPrecio);
            this.GBDetalle.Controls.Add(this.txtFechaInicio);
            this.GBDetalle.Controls.Add(this.txtStockDisponible);
            this.GBDetalle.Controls.Add(this.txtDescripcion);
            this.GBDetalle.Controls.Add(this.txtUsername);
            this.GBDetalle.Controls.Add(this.txtCodPublicacion);
            this.GBDetalle.Controls.Add(this.lblStockInicial);
            this.GBDetalle.Controls.Add(this.lblTipoPublicacion);
            this.GBDetalle.Controls.Add(this.lblEstadoPublicacion);
            this.GBDetalle.Controls.Add(this.lblPrecio);
            this.GBDetalle.Controls.Add(this.lblFechaInicio);
            this.GBDetalle.Controls.Add(this.lblFechaFinalizacion);
            this.GBDetalle.Controls.Add(this.lblStockDisponible);
            this.GBDetalle.Controls.Add(this.lblDescripcion);
            this.GBDetalle.Controls.Add(this.lblIdVendedor);
            this.GBDetalle.Controls.Add(this.lblVisibilidad);
            this.GBDetalle.Controls.Add(this.lblCodPublicacion);
            this.GBDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDetalle.Location = new System.Drawing.Point(13, 13);
            this.GBDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.GBDetalle.Name = "GBDetalle";
            this.GBDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.GBDetalle.Size = new System.Drawing.Size(645, 268);
            this.GBDetalle.TabIndex = 6;
            this.GBDetalle.TabStop = false;
            this.GBDetalle.Text = "Detalle de la publicación:";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.Location = new System.Drawing.Point(8, 229);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(62, 17);
            this.lblRubro.TabIndex = 25;
            this.lblRubro.Text = "Rubro/s:";
            // 
            // txtRubros
            // 
            this.txtRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubros.Location = new System.Drawing.Point(180, 225);
            this.txtRubros.Margin = new System.Windows.Forms.Padding(4);
            this.txtRubros.Name = "txtRubros";
            this.txtRubros.ReadOnly = true;
            this.txtRubros.Size = new System.Drawing.Size(415, 23);
            this.txtRubros.TabIndex = 4;
            this.txtRubros.TabStop = false;
            // 
            // txtTipoPublicacion
            // 
            this.txtTipoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPublicacion.Location = new System.Drawing.Point(463, 161);
            this.txtTipoPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoPublicacion.Name = "txtTipoPublicacion";
            this.txtTipoPublicacion.ReadOnly = true;
            this.txtTipoPublicacion.Size = new System.Drawing.Size(132, 23);
            this.txtTipoPublicacion.TabIndex = 24;
            this.txtTipoPublicacion.TabStop = false;
            // 
            // txtFechaFinalizacion
            // 
            this.txtFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinalizacion.Location = new System.Drawing.Point(463, 129);
            this.txtFechaFinalizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaFinalizacion.Name = "txtFechaFinalizacion";
            this.txtFechaFinalizacion.ReadOnly = true;
            this.txtFechaFinalizacion.Size = new System.Drawing.Size(132, 23);
            this.txtFechaFinalizacion.TabIndex = 23;
            this.txtFechaFinalizacion.TabStop = false;
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockInicial.Location = new System.Drawing.Point(463, 97);
            this.txtStockInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.ReadOnly = true;
            this.txtStockInicial.Size = new System.Drawing.Size(132, 23);
            this.txtStockInicial.TabIndex = 22;
            this.txtStockInicial.TabStop = false;
            // 
            // txtCodVisibilidad
            // 
            this.txtCodVisibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVisibilidad.Location = new System.Drawing.Point(463, 33);
            this.txtCodVisibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodVisibilidad.Name = "txtCodVisibilidad";
            this.txtCodVisibilidad.ReadOnly = true;
            this.txtCodVisibilidad.Size = new System.Drawing.Size(132, 23);
            this.txtCodVisibilidad.TabIndex = 21;
            this.txtCodVisibilidad.TabStop = false;
            // 
            // txtEstadoPublicacion
            // 
            this.txtEstadoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoPublicacion.Location = new System.Drawing.Point(180, 161);
            this.txtEstadoPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoPublicacion.Name = "txtEstadoPublicacion";
            this.txtEstadoPublicacion.ReadOnly = true;
            this.txtEstadoPublicacion.Size = new System.Drawing.Size(132, 23);
            this.txtEstadoPublicacion.TabIndex = 20;
            this.txtEstadoPublicacion.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(180, 193);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(132, 23);
            this.txtPrecio.TabIndex = 19;
            this.txtPrecio.TabStop = false;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Location = new System.Drawing.Point(180, 129);
            this.txtFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ReadOnly = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(132, 23);
            this.txtFechaInicio.TabIndex = 18;
            this.txtFechaInicio.TabStop = false;
            // 
            // txtStockDisponible
            // 
            this.txtStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockDisponible.Location = new System.Drawing.Point(180, 97);
            this.txtStockDisponible.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockDisponible.Name = "txtStockDisponible";
            this.txtStockDisponible.ReadOnly = true;
            this.txtStockDisponible.Size = new System.Drawing.Size(132, 23);
            this.txtStockDisponible.TabIndex = 17;
            this.txtStockDisponible.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(180, 65);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(415, 23);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(463, 193);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(132, 23);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.TabStop = false;
            // 
            // txtCodPublicacion
            // 
            this.txtCodPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPublicacion.Location = new System.Drawing.Point(180, 33);
            this.txtCodPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPublicacion.Name = "txtCodPublicacion";
            this.txtCodPublicacion.ReadOnly = true;
            this.txtCodPublicacion.Size = new System.Drawing.Size(132, 23);
            this.txtCodPublicacion.TabIndex = 4;
            this.txtCodPublicacion.TabStop = false;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInicial.Location = new System.Drawing.Point(321, 101);
            this.lblStockInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(86, 17);
            this.lblStockInicial.TabIndex = 10;
            this.lblStockInicial.Text = "Stock inicial:";
            // 
            // lblTipoPublicacion
            // 
            this.lblTipoPublicacion.AutoSize = true;
            this.lblTipoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPublicacion.Location = new System.Drawing.Point(321, 165);
            this.lblTipoPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPublicacion.Name = "lblTipoPublicacion";
            this.lblTipoPublicacion.Size = new System.Drawing.Size(135, 17);
            this.lblTipoPublicacion.TabIndex = 9;
            this.lblTipoPublicacion.Text = "Tipo de publicacion:";
            // 
            // lblEstadoPublicacion
            // 
            this.lblEstadoPublicacion.AutoSize = true;
            this.lblEstadoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPublicacion.Location = new System.Drawing.Point(8, 165);
            this.lblEstadoPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoPublicacion.Name = "lblEstadoPublicacion";
            this.lblEstadoPublicacion.Size = new System.Drawing.Size(166, 17);
            this.lblEstadoPublicacion.TabIndex = 8;
            this.lblEstadoPublicacion.Text = "Estado de la publicacion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(8, 197);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(8, 133);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 6;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(321, 133);
            this.lblFechaFinalizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(125, 17);
            this.lblFechaFinalizacion.TabIndex = 5;
            this.lblFechaFinalizacion.Text = "Fecha finalización:";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(8, 101);
            this.lblStockDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(115, 17);
            this.lblStockDisponible.TabIndex = 4;
            this.lblStockDisponible.Text = "Stock disponible:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(8, 69);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descirpcion:";
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVendedor.Location = new System.Drawing.Point(321, 197);
            this.lblIdVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(77, 17);
            this.lblIdVendedor.TabIndex = 2;
            this.lblIdVendedor.Text = "Username:";
            // 
            // lblVisibilidad
            // 
            this.lblVisibilidad.AutoSize = true;
            this.lblVisibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisibilidad.Location = new System.Drawing.Point(321, 37);
            this.lblVisibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisibilidad.Name = "lblVisibilidad";
            this.lblVisibilidad.Size = new System.Drawing.Size(105, 17);
            this.lblVisibilidad.TabIndex = 1;
            this.lblVisibilidad.Text = "Tipo visibilidad:";
            // 
            // lblCodPublicacion
            // 
            this.lblCodPublicacion.AutoSize = true;
            this.lblCodPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPublicacion.Location = new System.Drawing.Point(8, 37);
            this.lblCodPublicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodPublicacion.Name = "lblCodPublicacion";
            this.lblCodPublicacion.Size = new System.Drawing.Size(131, 17);
            this.lblCodPublicacion.TabIndex = 0;
            this.lblCodPublicacion.Text = "Código publicación:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(231, 312);
            this.cantidad.Multiline = true;
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(75, 31);
            this.cantidad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad a Comprar:";
            // 
            // DetallePublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.GBDetalle);
            this.Name = "DetallePublicacion";
            this.Text = "DetallePublicacion";
            this.Load += new System.EventHandler(this.DetallePublicacion_Load);
            this.GBDetalle.ResumeLayout(false);
            this.GBDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox GBDetalle;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox txtRubros;
        private System.Windows.Forms.TextBox txtTipoPublicacion;
        private System.Windows.Forms.TextBox txtFechaFinalizacion;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.TextBox txtCodVisibilidad;
        private System.Windows.Forms.TextBox txtEstadoPublicacion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtStockDisponible;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCodPublicacion;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label lblTipoPublicacion;
        private System.Windows.Forms.Label lblEstadoPublicacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIdVendedor;
        private System.Windows.Forms.Label lblVisibilidad;
        private System.Windows.Forms.Label lblCodPublicacion;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label1;
    }
}