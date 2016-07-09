namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class HistorialCliente
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
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPrimerPag = new System.Windows.Forms.Button();
            this.btnSiguientePag = new System.Windows.Forms.Button();
            this.btnAnteriorPag = new System.Windows.Forms.Button();
            this.tablaPublicaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estrellas5 = new System.Windows.Forms.TextBox();
            this.estrellas4 = new System.Windows.Forms.TextBox();
            this.estrellas3 = new System.Windows.Forms.TextBox();
            this.estrellas2 = new System.Windows.Forms.TextBox();
            this.estrellas1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cantOperacionesSinCalificar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(903, 489);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 53);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAbrirPublicacion
            // 
            this.btnAbrirPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPublicacion.Location = new System.Drawing.Point(478, 476);
            this.btnAbrirPublicacion.Name = "btnAbrirPublicacion";
            this.btnAbrirPublicacion.Size = new System.Drawing.Size(180, 38);
            this.btnAbrirPublicacion.TabIndex = 26;
            this.btnAbrirPublicacion.Text = "Abrir Publicacion";
            this.btnAbrirPublicacion.UseVisualStyleBackColor = true;
            this.btnAbrirPublicacion.Click += new System.EventHandler(this.btnAbrirPublicacion_Click);
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPag.Location = new System.Drawing.Point(377, 431);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(75, 23);
            this.btnUltimaPag.TabIndex = 25;
            this.btnUltimaPag.Text = "Ultima";
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            this.btnUltimaPag.Click += new System.EventHandler(this.btnUltimaPag_Click);
            // 
            // btnPrimerPag
            // 
            this.btnPrimerPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerPag.Location = new System.Drawing.Point(217, 431);
            this.btnPrimerPag.Name = "btnPrimerPag";
            this.btnPrimerPag.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerPag.TabIndex = 22;
            this.btnPrimerPag.Text = "Primera";
            this.btnPrimerPag.UseVisualStyleBackColor = true;
            this.btnPrimerPag.Click += new System.EventHandler(this.btnPrimerPag_Click);
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.Location = new System.Drawing.Point(338, 431);
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Size = new System.Drawing.Size(19, 23);
            this.btnSiguientePag.TabIndex = 24;
            this.btnSiguientePag.Text = ">";
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            this.btnSiguientePag.Click += new System.EventHandler(this.btnSiguientePag_Click);
            // 
            // btnAnteriorPag
            // 
            this.btnAnteriorPag.Location = new System.Drawing.Point(313, 431);
            this.btnAnteriorPag.Name = "btnAnteriorPag";
            this.btnAnteriorPag.Size = new System.Drawing.Size(19, 23);
            this.btnAnteriorPag.TabIndex = 23;
            this.btnAnteriorPag.Text = "<";
            this.btnAnteriorPag.UseVisualStyleBackColor = true;
            this.btnAnteriorPag.Click += new System.EventHandler(this.btnAnteriorPag_Click);
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
            this.tablaPublicaciones.Location = new System.Drawing.Point(22, 30);
            this.tablaPublicaciones.MultiSelect = false;
            this.tablaPublicaciones.Name = "tablaPublicaciones";
            this.tablaPublicaciones.ReadOnly = true;
            this.tablaPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPublicaciones.Size = new System.Drawing.Size(636, 380);
            this.tablaPublicaciones.TabIndex = 21;
            this.tablaPublicaciones.Click += new System.EventHandler(this.tablaPublicaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaPublicaciones);
            this.groupBox1.Controls.Add(this.btnUltimaPag);
            this.groupBox1.Controls.Add(this.btnAbrirPublicacion);
            this.groupBox1.Controls.Add(this.btnPrimerPag);
            this.groupBox1.Controls.Add(this.btnSiguientePag);
            this.groupBox1.Controls.Add(this.btnAnteriorPag);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 530);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras y Ofertas hechas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estrellas5);
            this.groupBox2.Controls.Add(this.estrellas4);
            this.groupBox2.Controls.Add(this.estrellas3);
            this.groupBox2.Controls.Add(this.estrellas2);
            this.groupBox2.Controls.Add(this.estrellas1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(716, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(364, 364);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de calificaciones por estrella:";
            // 
            // estrellas5
            // 
            this.estrellas5.Location = new System.Drawing.Point(238, 279);
            this.estrellas5.Name = "estrellas5";
            this.estrellas5.ReadOnly = true;
            this.estrellas5.Size = new System.Drawing.Size(100, 22);
            this.estrellas5.TabIndex = 11;
            // 
            // estrellas4
            // 
            this.estrellas4.Location = new System.Drawing.Point(238, 223);
            this.estrellas4.Name = "estrellas4";
            this.estrellas4.ReadOnly = true;
            this.estrellas4.Size = new System.Drawing.Size(100, 22);
            this.estrellas4.TabIndex = 10;
            // 
            // estrellas3
            // 
            this.estrellas3.Location = new System.Drawing.Point(238, 168);
            this.estrellas3.Name = "estrellas3";
            this.estrellas3.ReadOnly = true;
            this.estrellas3.Size = new System.Drawing.Size(100, 22);
            this.estrellas3.TabIndex = 9;
            // 
            // estrellas2
            // 
            this.estrellas2.Location = new System.Drawing.Point(238, 113);
            this.estrellas2.Name = "estrellas2";
            this.estrellas2.ReadOnly = true;
            this.estrellas2.Size = new System.Drawing.Size(100, 22);
            this.estrellas2.TabIndex = 8;
            // 
            // estrellas1
            // 
            this.estrellas1.Location = new System.Drawing.Point(238, 65);
            this.estrellas1.Name = "estrellas1";
            this.estrellas1.ReadOnly = true;
            this.estrellas1.Size = new System.Drawing.Size(100, 22);
            this.estrellas1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de 5 estrellas: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de 4 estrellas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de 3 estrellas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de 2 estrellas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de 1 estrella: ";
            // 
            // cantOperacionesSinCalificar
            // 
            this.cantOperacionesSinCalificar.Location = new System.Drawing.Point(256, 40);
            this.cantOperacionesSinCalificar.Name = "cantOperacionesSinCalificar";
            this.cantOperacionesSinCalificar.ReadOnly = true;
            this.cantOperacionesSinCalificar.Size = new System.Drawing.Size(100, 22);
            this.cantOperacionesSinCalificar.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cantidad de operaciones sin calificar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cantOperacionesSinCalificar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(708, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 82);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "HistorialCliente";
            this.Text = "HistorialCliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaPublicaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAbrirPublicacion;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Button btnPrimerPag;
        private System.Windows.Forms.Button btnSiguientePag;
        private System.Windows.Forms.Button btnAnteriorPag;
        private System.Windows.Forms.DataGridView tablaPublicaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox estrellas5;
        private System.Windows.Forms.TextBox estrellas4;
        private System.Windows.Forms.TextBox estrellas3;
        private System.Windows.Forms.TextBox estrellas2;
        private System.Windows.Forms.TextBox estrellas1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cantOperacionesSinCalificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}