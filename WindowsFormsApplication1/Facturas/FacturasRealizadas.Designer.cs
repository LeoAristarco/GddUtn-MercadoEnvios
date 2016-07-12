namespace WindowsFormsApplication1.Facturas
{
    partial class FacturasRealizadas
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
            this.buscarButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.nombreUserLabel = new System.Windows.Forms.Label();
            this.volverButton = new System.Windows.Forms.Button();
            this.tablaFacturas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroFechaActivado = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filtroMontoActivado = new System.Windows.Forms.CheckBox();
            this.montoHasta = new System.Windows.Forms.TextBox();
            this.montoDesde = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPrimerPag = new System.Windows.Forms.Button();
            this.btnSiguientePag = new System.Windows.Forms.Button();
            this.btnAnteriorPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(556, 407);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(101, 51);
            this.buscarButton.TabIndex = 19;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(841, 30);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(152, 22);
            this.username.TabIndex = 18;
            // 
            // nombreUserLabel
            // 
            this.nombreUserLabel.AutoSize = true;
            this.nombreUserLabel.Location = new System.Drawing.Point(678, 30);
            this.nombreUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreUserLabel.Name = "nombreUserLabel";
            this.nombreUserLabel.Size = new System.Drawing.Size(73, 17);
            this.nombreUserLabel.TabIndex = 17;
            this.nombreUserLabel.Text = "Username";
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(51, 407);
            this.volverButton.Margin = new System.Windows.Forms.Padding(4);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(101, 51);
            this.volverButton.TabIndex = 14;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // tablaFacturas
            // 
            this.tablaFacturas.AllowUserToAddRows = false;
            this.tablaFacturas.AllowUserToDeleteRows = false;
            this.tablaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaFacturas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFacturas.GridColor = System.Drawing.SystemColors.Window;
            this.tablaFacturas.Location = new System.Drawing.Point(7, 30);
            this.tablaFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.tablaFacturas.Name = "tablaFacturas";
            this.tablaFacturas.ReadOnly = true;
            this.tablaFacturas.RowHeadersVisible = false;
            this.tablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaFacturas.Size = new System.Drawing.Size(628, 304);
            this.tablaFacturas.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Desde";
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(169, 34);
            this.fechaDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(152, 22);
            this.fechaDesde.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hasta";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(169, 83);
            this.fechaHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(152, 22);
            this.fechaHasta.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filtroFechaActivado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaDesde);
            this.groupBox1.Controls.Add(this.fechaHasta);
            this.groupBox1.Location = new System.Drawing.Point(672, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 157);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros por fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filtro activado";
            // 
            // filtroFechaActivado
            // 
            this.filtroFechaActivado.AutoSize = true;
            this.filtroFechaActivado.Location = new System.Drawing.Point(169, 130);
            this.filtroFechaActivado.Name = "filtroFechaActivado";
            this.filtroFechaActivado.Size = new System.Drawing.Size(18, 17);
            this.filtroFechaActivado.TabIndex = 24;
            this.filtroFechaActivado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tablaFacturas);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 388);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturas de vendedor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.filtroMontoActivado);
            this.groupBox3.Controls.Add(this.montoHasta);
            this.groupBox3.Controls.Add(this.montoDesde);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(672, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 153);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros por monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Filtro activado";
            // 
            // filtroMontoActivado
            // 
            this.filtroMontoActivado.AutoSize = true;
            this.filtroMontoActivado.Location = new System.Drawing.Point(169, 123);
            this.filtroMontoActivado.Name = "filtroMontoActivado";
            this.filtroMontoActivado.Size = new System.Drawing.Size(18, 17);
            this.filtroMontoActivado.TabIndex = 26;
            this.filtroMontoActivado.UseVisualStyleBackColor = true;
            // 
            // montoHasta
            // 
            this.montoHasta.Location = new System.Drawing.Point(169, 78);
            this.montoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.montoHasta.Name = "montoHasta";
            this.montoHasta.Size = new System.Drawing.Size(152, 22);
            this.montoHasta.TabIndex = 25;
            // 
            // montoDesde
            // 
            this.montoDesde.Location = new System.Drawing.Point(169, 31);
            this.montoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.montoDesde.Name = "montoDesde";
            this.montoDesde.Size = new System.Drawing.Size(152, 22);
            this.montoDesde.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Desde";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hasta";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(926, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 50);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Sin filtros!";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPag.Location = new System.Drawing.Point(370, 366);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(75, 23);
            this.btnUltimaPag.TabIndex = 31;
            this.btnUltimaPag.Text = "Ultima";
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnPrimerPag
            // 
            this.btnPrimerPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerPag.Location = new System.Drawing.Point(210, 366);
            this.btnPrimerPag.Name = "btnPrimerPag";
            this.btnPrimerPag.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerPag.TabIndex = 28;
            this.btnPrimerPag.Text = "Primera";
            this.btnPrimerPag.UseVisualStyleBackColor = true;
            this.btnPrimerPag.Click += new System.EventHandler(this.btnPrimerPag_Click);
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.Location = new System.Drawing.Point(331, 366);
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Size = new System.Drawing.Size(19, 23);
            this.btnSiguientePag.TabIndex = 30;
            this.btnSiguientePag.Text = ">";
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            this.btnSiguientePag.Click += new System.EventHandler(this.btnSiguientePag_Click);
            // 
            // btnAnteriorPag
            // 
            this.btnAnteriorPag.Location = new System.Drawing.Point(306, 366);
            this.btnAnteriorPag.Name = "btnAnteriorPag";
            this.btnAnteriorPag.Size = new System.Drawing.Size(19, 23);
            this.btnAnteriorPag.TabIndex = 29;
            this.btnAnteriorPag.Text = "<";
            this.btnAnteriorPag.UseVisualStyleBackColor = true;
            this.btnAnteriorPag.Click += new System.EventHandler(this.btnAnteriorPag_Click);
            // 
            // FacturasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 467);
            this.Controls.Add(this.btnUltimaPag);
            this.Controls.Add(this.btnPrimerPag);
            this.Controls.Add(this.btnSiguientePag);
            this.Controls.Add(this.btnAnteriorPag);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.username);
            this.Controls.Add(this.nombreUserLabel);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.groupBox2);
            this.Name = "FacturasRealizadas";
            this.Text = "FacturarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacturasRealizadas_FormClosing);
            this.Load += new System.EventHandler(this.FacturasRealizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFacturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label nombreUserLabel;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridView tablaFacturas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox filtroFechaActivado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox montoHasta;
        private System.Windows.Forms.TextBox montoDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Button btnPrimerPag;
        private System.Windows.Forms.Button btnSiguientePag;
        private System.Windows.Forms.Button btnAnteriorPag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox filtroMontoActivado;
    }
}