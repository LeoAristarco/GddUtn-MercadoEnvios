namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class SeleccionHistorial
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
            this.bBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bOfertas = new System.Windows.Forms.Button();
            this.bSubastas = new System.Windows.Forms.Button();
            this.bCompras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(13, 186);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(153, 37);
            this.bBack.TabIndex = 8;
            this.bBack.Text = "<< Volver";
            this.bBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bOfertas);
            this.groupBox1.Controls.Add(this.bSubastas);
            this.groupBox1.Controls.Add(this.bCompras);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(153, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // bOfertas
            // 
            this.bOfertas.Location = new System.Drawing.Point(9, 113);
            this.bOfertas.Margin = new System.Windows.Forms.Padding(4);
            this.bOfertas.Name = "bOfertas";
            this.bOfertas.Size = new System.Drawing.Size(133, 37);
            this.bOfertas.TabIndex = 2;
            this.bOfertas.Text = "Ofertas";
            this.bOfertas.UseVisualStyleBackColor = true;
            // 
            // bSubastas
            // 
            this.bSubastas.Location = new System.Drawing.Point(9, 69);
            this.bSubastas.Margin = new System.Windows.Forms.Padding(4);
            this.bSubastas.Name = "bSubastas";
            this.bSubastas.Size = new System.Drawing.Size(133, 37);
            this.bSubastas.TabIndex = 1;
            this.bSubastas.Text = "Subastas";
            this.bSubastas.UseVisualStyleBackColor = true;
            // 
            // bCompras
            // 
            this.bCompras.Location = new System.Drawing.Point(9, 25);
            this.bCompras.Margin = new System.Windows.Forms.Padding(4);
            this.bCompras.Name = "bCompras";
            this.bCompras.Size = new System.Drawing.Size(133, 37);
            this.bCompras.TabIndex = 0;
            this.bCompras.Text = "Compras";
            this.bCompras.UseVisualStyleBackColor = true;
            // 
            // SeleccionHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 236);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.groupBox1);
            this.Name = "SeleccionHistorial";
            this.Text = "SeleccionHistorial";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bOfertas;
        private System.Windows.Forms.Button bSubastas;
        private System.Windows.Forms.Button bCompras;
    }
}