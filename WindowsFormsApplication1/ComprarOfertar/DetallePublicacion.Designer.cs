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
            this.rubro = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.fechaFin = new System.Windows.Forms.TextBox();
            this.visibilidad = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.fechaInicio = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.codigoPublicacion = new System.Windows.Forms.TextBox();
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
            this.GBDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(545, 305);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(423, 305);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 28);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Visible = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // GBDetalle
            // 
            this.GBDetalle.Controls.Add(this.lblRubro);
            this.GBDetalle.Controls.Add(this.rubro);
            this.GBDetalle.Controls.Add(this.tipo);
            this.GBDetalle.Controls.Add(this.fechaFin);
            this.GBDetalle.Controls.Add(this.visibilidad);
            this.GBDetalle.Controls.Add(this.estado);
            this.GBDetalle.Controls.Add(this.precio);
            this.GBDetalle.Controls.Add(this.fechaInicio);
            this.GBDetalle.Controls.Add(this.stock);
            this.GBDetalle.Controls.Add(this.descripcion);
            this.GBDetalle.Controls.Add(this.username);
            this.GBDetalle.Controls.Add(this.codigoPublicacion);
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
            this.lblRubro.Size = new System.Drawing.Size(51, 17);
            this.lblRubro.TabIndex = 25;
            this.lblRubro.Text = "Rubro:";
            // 
            // rubro
            // 
            this.rubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubro.Location = new System.Drawing.Point(180, 229);
            this.rubro.Margin = new System.Windows.Forms.Padding(4);
            this.rubro.Name = "rubro";
            this.rubro.ReadOnly = true;
            this.rubro.Size = new System.Drawing.Size(415, 23);
            this.rubro.TabIndex = 4;
            this.rubro.TabStop = false;
            // 
            // tipo
            // 
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(463, 131);
            this.tipo.Margin = new System.Windows.Forms.Padding(4);
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Size = new System.Drawing.Size(132, 23);
            this.tipo.TabIndex = 24;
            this.tipo.TabStop = false;
            // 
            // fechaFin
            // 
            this.fechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaFin.Location = new System.Drawing.Point(463, 99);
            this.fechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Size = new System.Drawing.Size(132, 23);
            this.fechaFin.TabIndex = 23;
            this.fechaFin.TabStop = false;
            // 
            // visibilidad
            // 
            this.visibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibilidad.Location = new System.Drawing.Point(463, 33);
            this.visibilidad.Margin = new System.Windows.Forms.Padding(4);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.ReadOnly = true;
            this.visibilidad.Size = new System.Drawing.Size(132, 23);
            this.visibilidad.TabIndex = 21;
            this.visibilidad.TabStop = false;
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(180, 161);
            this.estado.Margin = new System.Windows.Forms.Padding(4);
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Size = new System.Drawing.Size(132, 23);
            this.estado.TabIndex = 20;
            this.estado.TabStop = false;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(180, 193);
            this.precio.Margin = new System.Windows.Forms.Padding(4);
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Size = new System.Drawing.Size(132, 23);
            this.precio.TabIndex = 19;
            this.precio.TabStop = false;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaInicio.Location = new System.Drawing.Point(180, 129);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Size = new System.Drawing.Size(132, 23);
            this.fechaInicio.TabIndex = 18;
            this.fechaInicio.TabStop = false;
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(180, 97);
            this.stock.Margin = new System.Windows.Forms.Padding(4);
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Size = new System.Drawing.Size(132, 23);
            this.stock.TabIndex = 17;
            this.stock.TabStop = false;
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(180, 65);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(415, 23);
            this.descripcion.TabIndex = 16;
            this.descripcion.TabStop = false;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(463, 163);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(132, 23);
            this.username.TabIndex = 15;
            this.username.TabStop = false;
            // 
            // codigoPublicacion
            // 
            this.codigoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPublicacion.Location = new System.Drawing.Point(180, 33);
            this.codigoPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.codigoPublicacion.Name = "codigoPublicacion";
            this.codigoPublicacion.ReadOnly = true;
            this.codigoPublicacion.Size = new System.Drawing.Size(132, 23);
            this.codigoPublicacion.TabIndex = 4;
            this.codigoPublicacion.TabStop = false;
            // 
            // lblTipoPublicacion
            // 
            this.lblTipoPublicacion.AutoSize = true;
            this.lblTipoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPublicacion.Location = new System.Drawing.Point(321, 135);
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
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(321, 103);
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
            this.lblIdVendedor.Location = new System.Drawing.Point(321, 167);
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
            // DetallePublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 346);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.GBDetalle);
            this.Name = "DetallePublicacion";
            this.Text = "DetallePublicacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetallePublicacion_FormClosing);
            this.Load += new System.EventHandler(this.DetallePublicacion_Load);
            this.GBDetalle.ResumeLayout(false);
            this.GBDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox GBDetalle;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.TextBox rubro;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.TextBox fechaFin;
        private System.Windows.Forms.TextBox visibilidad;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox fechaInicio;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox codigoPublicacion;
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
    }
}