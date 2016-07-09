namespace WindowsFormsApplication1.ABM_Usuario.Empresa
{
    partial class ModificarEmpresa
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
            this.bModificar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.tNombreDeContacto = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tCiudad = new System.Windows.Forms.TextBox();
            this.tCodigoPostal = new System.Windows.Forms.TextBox();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.tCUIT = new System.Windows.Forms.TextBox();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHabilitado = new System.Windows.Forms.ComboBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPublicacionesGratuitas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(183, 551);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(231, 37);
            this.bModificar.TabIndex = 2;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(13, 551);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(113, 37);
            this.bVolver.TabIndex = 4;
            this.bVolver.Text = "<< Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAno);
            this.groupBox2.Controls.Add(this.cbMes);
            this.groupBox2.Controls.Add(this.cbDia);
            this.groupBox2.Controls.Add(this.tNombreDeContacto);
            this.groupBox2.Controls.Add(this.tEmail);
            this.groupBox2.Controls.Add(this.tCiudad);
            this.groupBox2.Controls.Add(this.tCodigoPostal);
            this.groupBox2.Controls.Add(this.tDireccion);
            this.groupBox2.Controls.Add(this.tTelefono);
            this.groupBox2.Controls.Add(this.tCUIT);
            this.groupBox2.Controls.Add(this.tRazonSocial);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(400, 353);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos corporativos";
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(309, 316);
            this.cbAno.Margin = new System.Windows.Forms.Padding(4);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(79, 24);
            this.cbAno.TabIndex = 10;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(240, 316);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(59, 24);
            this.cbMes.TabIndex = 9;
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(169, 316);
            this.cbDia.Margin = new System.Windows.Forms.Padding(4);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(59, 24);
            this.cbDia.TabIndex = 8;
            // 
            // tNombreDeContacto
            // 
            this.tNombreDeContacto.Location = new System.Drawing.Point(169, 279);
            this.tNombreDeContacto.Margin = new System.Windows.Forms.Padding(4);
            this.tNombreDeContacto.MaxLength = 50;
            this.tNombreDeContacto.Name = "tNombreDeContacto";
            this.tNombreDeContacto.Size = new System.Drawing.Size(219, 22);
            this.tNombreDeContacto.TabIndex = 7;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(169, 242);
            this.tEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tEmail.MaxLength = 50;
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(219, 22);
            this.tEmail.TabIndex = 6;
            // 
            // tCiudad
            // 
            this.tCiudad.Location = new System.Drawing.Point(169, 206);
            this.tCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.tCiudad.MaxLength = 50;
            this.tCiudad.Name = "tCiudad";
            this.tCiudad.Size = new System.Drawing.Size(219, 22);
            this.tCiudad.TabIndex = 5;
            // 
            // tCodigoPostal
            // 
            this.tCodigoPostal.Location = new System.Drawing.Point(169, 169);
            this.tCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.tCodigoPostal.MaxLength = 50;
            this.tCodigoPostal.Name = "tCodigoPostal";
            this.tCodigoPostal.Size = new System.Drawing.Size(219, 22);
            this.tCodigoPostal.TabIndex = 4;
            // 
            // tDireccion
            // 
            this.tDireccion.Location = new System.Drawing.Point(169, 132);
            this.tDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tDireccion.MaxLength = 255;
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(219, 22);
            this.tDireccion.TabIndex = 3;
            // 
            // tTelefono
            // 
            this.tTelefono.Location = new System.Drawing.Point(169, 95);
            this.tTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tTelefono.MaxLength = 18;
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(219, 22);
            this.tTelefono.TabIndex = 2;
            // 
            // tCUIT
            // 
            this.tCUIT.Location = new System.Drawing.Point(169, 58);
            this.tCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.tCUIT.MaxLength = 50;
            this.tCUIT.Name = "tCUIT";
            this.tCUIT.Size = new System.Drawing.Size(219, 22);
            this.tCUIT.TabIndex = 1;
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(169, 21);
            this.tRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.tRazonSocial.MaxLength = 255;
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(219, 22);
            this.tRazonSocial.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 320);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fecha de creación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 283);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Nombre de contacto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "E-Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Código Postal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "CUIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Razón Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHabilitado);
            this.groupBox1.Controls.Add(this.tPassword);
            this.groupBox1.Controls.Add(this.tUsername);
            this.groupBox1.Controls.Add(this.tPublicacionesGratuitas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos identificatorios";
            // 
            // cbHabilitado
            // 
            this.cbHabilitado.FormattingEnabled = true;
            this.cbHabilitado.Location = new System.Drawing.Point(169, 95);
            this.cbHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.cbHabilitado.Name = "cbHabilitado";
            this.cbHabilitado.Size = new System.Drawing.Size(219, 24);
            this.cbHabilitado.TabIndex = 2;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(169, 58);
            this.tPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tPassword.MaxLength = 255;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(219, 22);
            this.tPassword.TabIndex = 1;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(169, 21);
            this.tUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tUsername.MaxLength = 255;
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(219, 22);
            this.tUsername.TabIndex = 0;
            // 
            // tPublicacionesGratuitas
            // 
            this.tPublicacionesGratuitas.Location = new System.Drawing.Point(169, 132);
            this.tPublicacionesGratuitas.Margin = new System.Windows.Forms.Padding(4);
            this.tPublicacionesGratuitas.MaxLength = 50;
            this.tPublicacionesGratuitas.Name = "tPublicacionesGratuitas";
            this.tPublicacionesGratuitas.Size = new System.Drawing.Size(219, 22);
            this.tPublicacionesGratuitas.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publicaciones gratuitas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Habilitado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // ModificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 598);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarEmpresa";
            this.Text = "ModificarEmpresa";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.TextBox tNombreDeContacto;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tCiudad;
        private System.Windows.Forms.TextBox tCodigoPostal;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.TextBox tCUIT;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbHabilitado;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPublicacionesGratuitas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}