﻿namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class OfertaDlg
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtOferta = new System.Windows.Forms.TextBox();
            this.txtOfertaActual = new System.Windows.Forms.TextBox();
            this.lblOferta = new System.Windows.Forms.Label();
            this.lblOfertaActual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(162, 152);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtAceptar
            // 
            this.txtAceptar.Location = new System.Drawing.Point(270, 152);
            this.txtAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(100, 28);
            this.txtAceptar.TabIndex = 2;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.txtOferta);
            this.groupBox1.Controls.Add(this.txtOfertaActual);
            this.groupBox1.Controls.Add(this.lblOferta);
            this.groupBox1.Controls.Add(this.lblOfertaActual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese una oferta entera mayor a la actual";
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
            // 
            // txtOferta
            // 
            this.txtOferta.Location = new System.Drawing.Point(116, 73);
            this.txtOferta.Margin = new System.Windows.Forms.Padding(4);
            this.txtOferta.Name = "txtOferta";
            this.txtOferta.Size = new System.Drawing.Size(132, 23);
            this.txtOferta.TabIndex = 5;
            // 
            // txtOfertaActual
            // 
            this.txtOfertaActual.Location = new System.Drawing.Point(116, 38);
            this.txtOfertaActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtOfertaActual.Name = "txtOfertaActual";
            this.txtOfertaActual.ReadOnly = true;
            this.txtOfertaActual.Size = new System.Drawing.Size(132, 23);
            this.txtOfertaActual.TabIndex = 4;
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
            // OfertaDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 192);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfertaDlg";
            this.Text = "OfertaDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button txtAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtOferta;
        private System.Windows.Forms.TextBox txtOfertaActual;
        private System.Windows.Forms.Label lblOferta;
        private System.Windows.Forms.Label lblOfertaActual;
    }
}