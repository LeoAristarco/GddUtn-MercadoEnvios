namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class HistorialSubastas
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
            this.pAnterior = new System.Windows.Forms.Button();
            this.pSiguiente = new System.Windows.Forms.Button();
            this.dgSubastasGanadas = new System.Windows.Forms.DataGridView();
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubastasGanadas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pAnterior);
            this.groupBox1.Controls.Add(this.pSiguiente);
            this.groupBox1.Controls.Add(this.dgSubastasGanadas);
            this.groupBox1.Controls.Add(this.bBack);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(787, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subastas ganadas";
            // 
            // pAnterior
            // 
            this.pAnterior.Location = new System.Drawing.Point(672, 332);
            this.pAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.pAnterior.Name = "pAnterior";
            this.pAnterior.Size = new System.Drawing.Size(47, 37);
            this.pAnterior.TabIndex = 9;
            this.pAnterior.Text = "<<";
            this.pAnterior.UseVisualStyleBackColor = true;
            // 
            // pSiguiente
            // 
            this.pSiguiente.Location = new System.Drawing.Point(728, 332);
            this.pSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.pSiguiente.Name = "pSiguiente";
            this.pSiguiente.Size = new System.Drawing.Size(47, 37);
            this.pSiguiente.TabIndex = 8;
            this.pSiguiente.Text = ">>";
            this.pSiguiente.UseVisualStyleBackColor = true;
            // 
            // dgSubastasGanadas
            // 
            this.dgSubastasGanadas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgSubastasGanadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubastasGanadas.Location = new System.Drawing.Point(13, 25);
            this.dgSubastasGanadas.Margin = new System.Windows.Forms.Padding(4);
            this.dgSubastasGanadas.Name = "dgSubastasGanadas";
            this.dgSubastasGanadas.Size = new System.Drawing.Size(760, 299);
            this.dgSubastasGanadas.TabIndex = 7;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(12, 332);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(160, 37);
            this.bBack.TabIndex = 6;
            this.bBack.Text = "<< Volver";
            this.bBack.UseVisualStyleBackColor = true;
            // 
            // HistorialSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "HistorialSubastas";
            this.Text = "HistorialSubastas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubastasGanadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pAnterior;
        private System.Windows.Forms.Button pSiguiente;
        private System.Windows.Forms.DataGridView dgSubastasGanadas;
        private System.Windows.Forms.Button bBack;
    }
}