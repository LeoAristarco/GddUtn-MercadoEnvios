namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class BuscarPublicacionesUser
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAbrirPublicacion = new System.Windows.Forms.Button();
            this.tablaPublicaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(12, 419);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAbrirPublicacion
            // 
            this.btnAbrirPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPublicacion.Location = new System.Drawing.Point(685, 411);
            this.btnAbrirPublicacion.Name = "btnAbrirPublicacion";
            this.btnAbrirPublicacion.Size = new System.Drawing.Size(180, 38);
            this.btnAbrirPublicacion.TabIndex = 26;
            this.btnAbrirPublicacion.Text = "Modificar Publicacion";
            this.btnAbrirPublicacion.UseVisualStyleBackColor = true;
            this.btnAbrirPublicacion.Click += new System.EventHandler(this.btnAbrirPublicacion_Click);
            // 
            // tablaPublicaciones
            // 
            this.tablaPublicaciones.AllowUserToAddRows = false;
            this.tablaPublicaciones.AllowUserToDeleteRows = false;
            this.tablaPublicaciones.AllowUserToResizeColumns = false;
            this.tablaPublicaciones.AllowUserToResizeRows = false;
            this.tablaPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPublicaciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPublicaciones.Location = new System.Drawing.Point(12, 12);
            this.tablaPublicaciones.MultiSelect = false;
            this.tablaPublicaciones.Name = "tablaPublicaciones";
            this.tablaPublicaciones.ReadOnly = true;
            this.tablaPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPublicaciones.Size = new System.Drawing.Size(853, 380);
            this.tablaPublicaciones.TabIndex = 21;
            this.tablaPublicaciones.Click += new System.EventHandler(this.tablaPublicaciones_Click);
            // 
            // BuscarPublicacionesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 464);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAbrirPublicacion);
            this.Controls.Add(this.tablaPublicaciones);
            this.Name = "BuscarPublicacionesUser";
            this.Text = "BuscarPublicacionesUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarPublicacionesUser_FormClosing);
            this.Load += new System.EventHandler(this.BuscarPublicacionesUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAbrirPublicacion;
        private System.Windows.Forms.DataGridView tablaPublicaciones;
    }
}