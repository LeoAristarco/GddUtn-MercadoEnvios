namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    partial class BuscarEmpresa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaEmpresas = new System.Windows.Forms.DataGridView();
            this.buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.filtroRazonSocial = new System.Windows.Forms.TextBox();
            this.filtroCuit = new System.Windows.Forms.TextBox();
            this.filtroMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpresas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaEmpresas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresas encontradas";
            // 
            // tablaEmpresas
            // 
            this.tablaEmpresas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.tablaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEmpresas.Location = new System.Drawing.Point(12, 25);
            this.tablaEmpresas.Margin = new System.Windows.Forms.Padding(4);
            this.tablaEmpresas.Name = "tablaEmpresas";
            this.tablaEmpresas.Size = new System.Drawing.Size(535, 209);
            this.tablaEmpresas.TabIndex = 0;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(614, 289);
            this.buscar.Margin = new System.Windows.Forms.Padding(4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(148, 47);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.filtroMail);
            this.groupBox2.Controls.Add(this.filtroCuit);
            this.groupBox2.Controls.Add(this.filtroRazonSocial);
            this.groupBox2.Location = new System.Drawing.Point(581, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(302, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por:";
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(221, 289);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(148, 47);
            this.bVolver.TabIndex = 5;
            this.bVolver.Text = "<< Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            // 
            // filtroRazonSocial
            // 
            this.filtroRazonSocial.Location = new System.Drawing.Point(104, 44);
            this.filtroRazonSocial.Name = "filtroRazonSocial";
            this.filtroRazonSocial.Size = new System.Drawing.Size(191, 22);
            this.filtroRazonSocial.TabIndex = 0;
            // 
            // filtroCuit
            // 
            this.filtroCuit.Location = new System.Drawing.Point(104, 115);
            this.filtroCuit.Name = "filtroCuit";
            this.filtroCuit.Size = new System.Drawing.Size(191, 22);
            this.filtroCuit.TabIndex = 1;
            // 
            // filtroMail
            // 
            this.filtroMail.Location = new System.Drawing.Point(104, 181);
            this.filtroMail.Name = "filtroMail";
            this.filtroMail.Size = new System.Drawing.Size(191, 22);
            this.filtroMail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CUIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail:";
            // 
            // BuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 349);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarEmpresa";
            this.Text = "BuscarEmpresa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEmpresas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaEmpresas;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroMail;
        private System.Windows.Forms.TextBox filtroCuit;
        private System.Windows.Forms.TextBox filtroRazonSocial;
    }
}