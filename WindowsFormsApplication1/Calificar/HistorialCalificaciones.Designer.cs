namespace WindowsFormsApplication1.Calificar
{
    partial class HistorialCalificaciones
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
            this.tablaUltimas5Compras = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUltimas5Compras)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaUltimas5Compras);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(671, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de ultimas 5 compras realizadas:";
            // 
            // tablaUltimas5Compras
            // 
            this.tablaUltimas5Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUltimas5Compras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaUltimas5Compras.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaUltimas5Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUltimas5Compras.Location = new System.Drawing.Point(8, 40);
            this.tablaUltimas5Compras.Margin = new System.Windows.Forms.Padding(4);
            this.tablaUltimas5Compras.Name = "tablaUltimas5Compras";
            this.tablaUltimas5Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaUltimas5Compras.Size = new System.Drawing.Size(655, 321);
            this.tablaUltimas5Compras.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(704, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(396, 341);
            this.groupBox2.TabIndex = 6;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistorialCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HistorialCalificaciones";
            this.Text = "HistorialCalificaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialCalificaciones_FormClosing);
            this.Load += new System.EventHandler(this.HistorialCalificaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUltimas5Compras)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaUltimas5Compras;
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
        private System.Windows.Forms.Button button1;
    }
}