namespace WindowsFormsApplication1.Calificar
{
    partial class CalificarVendedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerPublicacion = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.tablaPublicacionesCalificar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicacionesCalificar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(584, 483);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerPublicacion);
            this.groupBox1.Controls.Add(this.btnCalificar);
            this.groupBox1.Controls.Add(this.tablaPublicacionesCalificar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(671, 463);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de compras realizadas:";
            // 
            // btnVerPublicacion
            // 
            this.btnVerPublicacion.Location = new System.Drawing.Point(404, 23);
            this.btnVerPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerPublicacion.Name = "btnVerPublicacion";
            this.btnVerPublicacion.Size = new System.Drawing.Size(151, 28);
            this.btnVerPublicacion.TabIndex = 1;
            this.btnVerPublicacion.Text = "Ver publicación";
            this.btnVerPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(563, 23);
            this.btnCalificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(100, 28);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // tablaPublicacionesCalificar
            // 
            this.tablaPublicacionesCalificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPublicacionesCalificar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPublicacionesCalificar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaPublicacionesCalificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPublicacionesCalificar.Location = new System.Drawing.Point(8, 59);
            this.tablaPublicacionesCalificar.Margin = new System.Windows.Forms.Padding(4);
            this.tablaPublicacionesCalificar.Name = "tablaPublicacionesCalificar";
            this.tablaPublicacionesCalificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPublicacionesCalificar.Size = new System.Drawing.Size(655, 396);
            this.tablaPublicacionesCalificar.TabIndex = 0;
            // 
            // CalificarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 521);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalificarVendedor";
            this.Text = "CalificarVendedor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicacionesCalificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerPublicacion;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.DataGridView tablaPublicacionesCalificar;
    }
}