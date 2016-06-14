namespace WindowsFormsApplication1.Calificar
{
    partial class CalificarDlg
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.rbOpciones = new System.Windows.Forms.RadioButton();
            this.rbTextoLibre = new System.Windows.Forms.RadioButton();
            this.txtTextoLibre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(217, 376);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(325, 376);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.cmbOpciones);
            this.groupBox1.Controls.Add(this.rbOpciones);
            this.groupBox1.Controls.Add(this.rbTextoLibre);
            this.groupBox1.Controls.Add(this.txtTextoLibre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEstrellas);
            this.groupBox1.Controls.Add(this.lblEstrellas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 356);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la cantidad de estrellas que desea puntuar:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(8, 320);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 28);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Location = new System.Drawing.Point(196, 137);
            this.cmbOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(160, 24);
            this.cmbOpciones.TabIndex = 3;
            // 
            // rbOpciones
            // 
            this.rbOpciones.AutoSize = true;
            this.rbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpciones.Location = new System.Drawing.Point(8, 137);
            this.rbOpciones.Margin = new System.Windows.Forms.Padding(4);
            this.rbOpciones.Name = "rbOpciones";
            this.rbOpciones.Size = new System.Drawing.Size(176, 21);
            this.rbOpciones.TabIndex = 2;
            this.rbOpciones.TabStop = true;
            this.rbOpciones.Text = "Seleccione una opción:";
            this.rbOpciones.UseVisualStyleBackColor = true;
            // 
            // rbTextoLibre
            // 
            this.rbTextoLibre.AutoSize = true;
            this.rbTextoLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTextoLibre.Location = new System.Drawing.Point(8, 191);
            this.rbTextoLibre.Margin = new System.Windows.Forms.Padding(4);
            this.rbTextoLibre.Name = "rbTextoLibre";
            this.rbTextoLibre.Size = new System.Drawing.Size(99, 21);
            this.rbTextoLibre.TabIndex = 4;
            this.rbTextoLibre.TabStop = true;
            this.rbTextoLibre.Text = "Texto libre:";
            this.rbTextoLibre.UseVisualStyleBackColor = true;
            // 
            // txtTextoLibre
            // 
            this.txtTextoLibre.Location = new System.Drawing.Point(8, 219);
            this.txtTextoLibre.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextoLibre.Multiline = true;
            this.txtTextoLibre.Name = "txtTextoLibre";
            this.txtTextoLibre.Size = new System.Drawing.Size(348, 93);
            this.txtTextoLibre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Describa su experiencia (OPCIONAL) :";
            // 
            // cmbEstrellas
            // 
            this.cmbEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrellas.FormattingEnabled = true;
            this.cmbEstrellas.Location = new System.Drawing.Point(81, 34);
            this.cmbEstrellas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(160, 24);
            this.cmbEstrellas.TabIndex = 1;
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Location = new System.Drawing.Point(8, 38);
            this.lblEstrellas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(66, 17);
            this.lblEstrellas.TabIndex = 2;
            this.lblEstrellas.Text = "Estrellas:";
            // 
            // CalificarDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 416);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CalificarDlg";
            this.Text = "CalificarDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.RadioButton rbOpciones;
        private System.Windows.Forms.RadioButton rbTextoLibre;
        private System.Windows.Forms.TextBox txtTextoLibre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstrellas;
        private System.Windows.Forms.Label lblEstrellas;
    }
}