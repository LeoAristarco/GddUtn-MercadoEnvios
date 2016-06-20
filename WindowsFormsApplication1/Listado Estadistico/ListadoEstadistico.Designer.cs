namespace WindowsFormsApplication1.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.limpiarBoton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mes = new System.Windows.Forms.ComboBox();
            this.mesLabel = new System.Windows.Forms.Label();
            this.filtro = new System.Windows.Forms.ComboBox();
            this.filtroEspecial = new System.Windows.Forms.Label();
            this.tablaEstadistica = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.tipoListado = new System.Windows.Forms.ComboBox();
            this.TipoListadoLabel = new System.Windows.Forms.Label();
            this.trimestre = new System.Windows.Forms.ComboBox();
            this.TrimestreLabel = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.TextBox();
            this.anioLabel = new System.Windows.Forms.Label();
            this.volverButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadistica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarBoton
            // 
            this.limpiarBoton.Location = new System.Drawing.Point(12, 442);
            this.limpiarBoton.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarBoton.Name = "limpiarBoton";
            this.limpiarBoton.Size = new System.Drawing.Size(179, 33);
            this.limpiarBoton.TabIndex = 22;
            this.limpiarBoton.Text = "Limpiar";
            this.limpiarBoton.UseVisualStyleBackColor = true;
            this.limpiarBoton.Click += new System.EventHandler(this.limpiarBoton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mes);
            this.groupBox2.Controls.Add(this.mesLabel);
            this.groupBox2.Controls.Add(this.filtro);
            this.groupBox2.Controls.Add(this.filtroEspecial);
            this.groupBox2.Controls.Add(this.tablaEstadistica);
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(675, 225);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOP 5:";
            // 
            // mes
            // 
            this.mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mes.Enabled = false;
            this.mes.FormattingEnabled = true;
            this.mes.Location = new System.Drawing.Point(342, 27);
            this.mes.Margin = new System.Windows.Forms.Padding(4);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(137, 24);
            this.mes.TabIndex = 20;
            // 
            // mesLabel
            // 
            this.mesLabel.AutoSize = true;
            this.mesLabel.Location = new System.Drawing.Point(287, 30);
            this.mesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(38, 17);
            this.mesLabel.TabIndex = 16;
            this.mesLabel.Text = "Mes:";
            // 
            // filtro
            // 
            this.filtro.Enabled = false;
            this.filtro.FormattingEnabled = true;
            this.filtro.Location = new System.Drawing.Point(107, 27);
            this.filtro.Margin = new System.Windows.Forms.Padding(4);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(121, 24);
            this.filtro.TabIndex = 15;
            this.filtro.SelectedIndexChanged += new System.EventHandler(this.filtro_SelectedIndexChanged);
            // 
            // filtroEspecial
            // 
            this.filtroEspecial.AutoSize = true;
            this.filtroEspecial.Location = new System.Drawing.Point(8, 30);
            this.filtroEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtroEspecial.Name = "filtroEspecial";
            this.filtroEspecial.Size = new System.Drawing.Size(0, 17);
            this.filtroEspecial.TabIndex = 14;
            // 
            // tablaEstadistica
            // 
            this.tablaEstadistica.AllowUserToAddRows = false;
            this.tablaEstadistica.AllowUserToDeleteRows = false;
            this.tablaEstadistica.AllowUserToResizeColumns = false;
            this.tablaEstadistica.AllowUserToResizeRows = false;
            this.tablaEstadistica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaEstadistica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaEstadistica.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEstadistica.GridColor = System.Drawing.SystemColors.Window;
            this.tablaEstadistica.Location = new System.Drawing.Point(8, 59);
            this.tablaEstadistica.Margin = new System.Windows.Forms.Padding(4);
            this.tablaEstadistica.Name = "tablaEstadistica";
            this.tablaEstadistica.ReadOnly = true;
            this.tablaEstadistica.RowHeadersVisible = false;
            this.tablaEstadistica.Size = new System.Drawing.Size(659, 151);
            this.tablaEstadistica.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buscarButton);
            this.groupBox1.Controls.Add(this.tipoListado);
            this.groupBox1.Controls.Add(this.TipoListadoLabel);
            this.groupBox1.Controls.Add(this.trimestre);
            this.groupBox1.Controls.Add(this.TrimestreLabel);
            this.groupBox1.Controls.Add(this.anio);
            this.groupBox1.Controls.Add(this.anioLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(675, 190);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Los campos marcados con (*) son OBLIGATORIOS";
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(553, 143);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 28);
            this.buscarButton.TabIndex = 3;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // tipoListado
            // 
            this.tipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoListado.Enabled = false;
            this.tipoListado.FormattingEnabled = true;
            this.tipoListado.Location = new System.Drawing.Point(181, 48);
            this.tipoListado.Margin = new System.Windows.Forms.Padding(4);
            this.tipoListado.Name = "tipoListado";
            this.tipoListado.Size = new System.Drawing.Size(471, 24);
            this.tipoListado.TabIndex = 0;
            this.tipoListado.SelectedIndexChanged += new System.EventHandler(this.tipoListado_SelectedIndexChanged);
            // 
            // TipoListadoLabel
            // 
            this.TipoListadoLabel.AutoSize = true;
            this.TipoListadoLabel.Location = new System.Drawing.Point(49, 48);
            this.TipoListadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TipoListadoLabel.Name = "TipoListadoLabel";
            this.TipoListadoLabel.Size = new System.Drawing.Size(129, 17);
            this.TipoListadoLabel.TabIndex = 4;
            this.TipoListadoLabel.Text = "Tipo de Listado (*):";
            // 
            // trimestre
            // 
            this.trimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimestre.Enabled = false;
            this.trimestre.FormattingEnabled = true;
            this.trimestre.Location = new System.Drawing.Point(457, 95);
            this.trimestre.Margin = new System.Windows.Forms.Padding(4);
            this.trimestre.Name = "trimestre";
            this.trimestre.Size = new System.Drawing.Size(195, 24);
            this.trimestre.TabIndex = 2;
            this.trimestre.SelectedIndexChanged += new System.EventHandler(this.trimestre_SelectedIndexChanged);
            // 
            // TrimestreLabel
            // 
            this.TrimestreLabel.AutoSize = true;
            this.TrimestreLabel.Location = new System.Drawing.Point(365, 98);
            this.TrimestreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TrimestreLabel.Name = "TrimestreLabel";
            this.TrimestreLabel.Size = new System.Drawing.Size(91, 17);
            this.TrimestreLabel.TabIndex = 2;
            this.TrimestreLabel.Text = "Trimestre (*):";
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(181, 95);
            this.anio.Margin = new System.Windows.Forms.Padding(4);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(132, 22);
            this.anio.TabIndex = 1;
            this.anio.TextChanged += new System.EventHandler(this.anio_TextChanged);
            // 
            // anioLabel
            // 
            this.anioLabel.AutoSize = true;
            this.anioLabel.Location = new System.Drawing.Point(49, 98);
            this.anioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anioLabel.Name = "anioLabel";
            this.anioLabel.Size = new System.Drawing.Size(56, 17);
            this.anioLabel.TabIndex = 0;
            this.anioLabel.Text = "Año (*):";
            // 
            // volverButton
            // 
            this.volverButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.volverButton.Location = new System.Drawing.Point(509, 442);
            this.volverButton.Margin = new System.Windows.Forms.Padding(4);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(179, 33);
            this.volverButton.TabIndex = 21;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 490);
            this.Controls.Add(this.limpiarBoton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.volverButton);
            this.Name = "ListadoEstadistico";
            this.Text = "ListadoEstadisticoForm";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEstadistica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiarBoton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mesLabel;
        private System.Windows.Forms.ComboBox filtro;
        private System.Windows.Forms.Label filtroEspecial;
        private System.Windows.Forms.DataGridView tablaEstadistica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ComboBox tipoListado;
        private System.Windows.Forms.Label TipoListadoLabel;
        private System.Windows.Forms.ComboBox trimestre;
        private System.Windows.Forms.Label TrimestreLabel;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.Label anioLabel;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.ComboBox mes;
    }
}