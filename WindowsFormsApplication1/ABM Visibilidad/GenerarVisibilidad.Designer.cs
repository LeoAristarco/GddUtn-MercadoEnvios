namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class GenerarVisibilidad
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
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.TextBox();
            this.costo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(140, 199);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 28);
            this.limpiarButton.TabIndex = 30;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "%";
            // 
            // ConfirmarButton
            // 
            this.ConfirmarButton.Location = new System.Drawing.Point(253, 199);
            this.ConfirmarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmarButton.Name = "ConfirmarButton";
            this.ConfirmarButton.Size = new System.Drawing.Size(100, 28);
            this.ConfirmarButton.TabIndex = 25;
            this.ConfirmarButton.Text = "Confirmar";
            this.ConfirmarButton.UseVisualStyleBackColor = true;
            this.ConfirmarButton.Click += new System.EventHandler(this.ConfirmarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(23, 199);
            this.cancelarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(100, 28);
            this.cancelarButton.TabIndex = 24;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // porcentaje
            // 
            this.porcentaje.Location = new System.Drawing.Point(219, 138);
            this.porcentaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(47, 22);
            this.porcentaje.TabIndex = 21;
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(219, 81);
            this.costo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(132, 22);
            this.costo.TabIndex = 19;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(220, 26);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(132, 22);
            this.nombre.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Porcentaje por Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Costo de Publicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // GenerarVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 256);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenerarVisibilidad";
            this.Text = "EditorDeVisibilidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerarVisibilidad_FormClosing);
            this.Load += new System.EventHandler(this.GenerarVisibilidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox porcentaje;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}