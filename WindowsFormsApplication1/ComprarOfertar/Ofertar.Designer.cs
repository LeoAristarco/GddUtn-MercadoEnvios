namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class Ofertar
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
            this.txtAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.montoOferta = new System.Windows.Forms.TextBox();
            this.ofertaActual = new System.Windows.Forms.TextBox();
            this.lblOferta = new System.Windows.Forms.Label();
            this.lblOfertaActual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(161, 203);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAceptar
            // 
            this.txtAceptar.Location = new System.Drawing.Point(270, 203);
            this.txtAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(100, 28);
            this.txtAceptar.TabIndex = 2;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.UseVisualStyleBackColor = true;
            this.txtAceptar.Click += new System.EventHandler(this.txtAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.montoOferta);
            this.groupBox1.Controls.Add(this.ofertaActual);
            this.groupBox1.Controls.Add(this.lblOferta);
            this.groupBox1.Controls.Add(this.lblOfertaActual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese una oferta entera mayor a la actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Con Envio";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(257, 70);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(64, 28);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // montoOferta
            // 
            this.montoOferta.Location = new System.Drawing.Point(116, 73);
            this.montoOferta.Margin = new System.Windows.Forms.Padding(4);
            this.montoOferta.Name = "montoOferta";
            this.montoOferta.Size = new System.Drawing.Size(132, 23);
            this.montoOferta.TabIndex = 5;
            // 
            // ofertaActual
            // 
            this.ofertaActual.Location = new System.Drawing.Point(116, 38);
            this.ofertaActual.Margin = new System.Windows.Forms.Padding(4);
            this.ofertaActual.Name = "ofertaActual";
            this.ofertaActual.ReadOnly = true;
            this.ofertaActual.Size = new System.Drawing.Size(132, 23);
            this.ofertaActual.TabIndex = 4;
            // 
            // lblOferta
            // 
            this.lblOferta.AutoSize = true;
            this.lblOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOferta.Location = new System.Drawing.Point(8, 76);
            this.lblOferta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOferta.Name = "lblOferta";
            this.lblOferta.Size = new System.Drawing.Size(52, 17);
            this.lblOferta.TabIndex = 3;
            this.lblOferta.Text = "Oferta:";
            // 
            // lblOfertaActual
            // 
            this.lblOfertaActual.AutoSize = true;
            this.lblOfertaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfertaActual.Location = new System.Drawing.Point(8, 42);
            this.lblOfertaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOfertaActual.Name = "lblOfertaActual";
            this.lblOfertaActual.Size = new System.Drawing.Size(94, 17);
            this.lblOfertaActual.TabIndex = 2;
            this.lblOfertaActual.Text = "Oferta actual:";
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 242);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ofertar";
            this.Text = "OfertaDlg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ofertar_FormClosing);
            this.Load += new System.EventHandler(this.Ofertar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button txtAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox montoOferta;
        private System.Windows.Forms.TextBox ofertaActual;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.Label lblOfertaActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}