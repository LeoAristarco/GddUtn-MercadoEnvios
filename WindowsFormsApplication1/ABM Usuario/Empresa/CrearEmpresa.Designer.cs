namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class CrearEmpresa
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rubro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.nombreDeContacto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.TextBox();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.numeroDePiso = new System.Windows.Forms.TextBox();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.numeroDeCalle = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(299, 664);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 37);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(11, 664);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 37);
            this.back.TabIndex = 3;
            this.back.Text = "<< Volver";
            this.back.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaNacimiento);
            this.groupBox1.Controls.Add(this.rubro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.localidad);
            this.groupBox1.Controls.Add(this.registrar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nombreDeContacto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.departamento);
            this.groupBox1.Controls.Add(this.cuit);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ciudad);
            this.groupBox1.Controls.Add(this.numeroDePiso);
            this.groupBox1.Controls.Add(this.codigoPostal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.numeroDeCalle);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.razonSocial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.calle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 634);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva empresa";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(187, 380);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(201, 22);
            this.fechaNacimiento.TabIndex = 60;
            // 
            // rubro
            // 
            this.rubro.Location = new System.Drawing.Point(185, 536);
            this.rubro.Margin = new System.Windows.Forms.Padding(4);
            this.rubro.MaxLength = 50;
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(201, 22);
            this.rubro.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Rubro (*)";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(187, 294);
            this.localidad.Margin = new System.Windows.Forms.Padding(4);
            this.localidad.MaxLength = 255;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(201, 22);
            this.localidad.TabIndex = 56;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(189, 583);
            this.registrar.Margin = new System.Windows.Forms.Padding(4);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(203, 37);
            this.registrar.TabIndex = 8;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 298);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 57;
            this.label14.Text = "Localidad";
            // 
            // nombreDeContacto
            // 
            this.nombreDeContacto.Location = new System.Drawing.Point(187, 493);
            this.nombreDeContacto.Margin = new System.Windows.Forms.Padding(4);
            this.nombreDeContacto.MaxLength = 50;
            this.nombreDeContacto.Name = "nombreDeContacto";
            this.nombreDeContacto.Size = new System.Drawing.Size(201, 22);
            this.nombreDeContacto.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Fecha de nacimiento (*)";
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(187, 253);
            this.departamento.Margin = new System.Windows.Forms.Padding(4);
            this.departamento.MaxLength = 255;
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(201, 22);
            this.departamento.TabIndex = 54;
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(187, 456);
            this.cuit.Margin = new System.Windows.Forms.Padding(4);
            this.cuit.MaxLength = 50;
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(201, 22);
            this.cuit.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = " Departamento";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(187, 420);
            this.ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.ciudad.MaxLength = 50;
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(201, 22);
            this.ciudad.TabIndex = 5;
            // 
            // numeroDePiso
            // 
            this.numeroDePiso.Location = new System.Drawing.Point(187, 213);
            this.numeroDePiso.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDePiso.MaxLength = 255;
            this.numeroDePiso.Name = "numeroDePiso";
            this.numeroDePiso.Size = new System.Drawing.Size(201, 22);
            this.numeroDePiso.TabIndex = 52;
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(187, 333);
            this.codigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.codigoPostal.MaxLength = 50;
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(201, 22);
            this.codigoPostal.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 217);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Numero de piso";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(187, 95);
            this.telefono.Margin = new System.Windows.Forms.Padding(4);
            this.telefono.MaxLength = 18;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(201, 22);
            this.telefono.TabIndex = 2;
            // 
            // numeroDeCalle
            // 
            this.numeroDeCalle.Location = new System.Drawing.Point(187, 172);
            this.numeroDeCalle.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDeCalle.MaxLength = 255;
            this.numeroDeCalle.Name = "numeroDeCalle";
            this.numeroDeCalle.Size = new System.Drawing.Size(201, 22);
            this.numeroDeCalle.TabIndex = 50;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(187, 58);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 22);
            this.email.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Numero de calle (*)";
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(187, 21);
            this.razonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.razonSocial.MaxLength = 255;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(201, 22);
            this.razonSocial.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 594);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "(*) = Campo obligatorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código postal (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 497);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre de contacto";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(187, 132);
            this.calle.Margin = new System.Windows.Forms.Padding(4);
            this.calle.MaxLength = 255;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(201, 22);
            this.calle.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "E-mail (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Razón Social (*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 136);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "Calle (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CUIT (*)";
            // 
            // CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 711);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearEmpresa";
            this.Text = "CrearEmpresa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearEmpresa_FormClosing);
            this.Load += new System.EventHandler(this.CrearEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.TextBox nombreDeContacto;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numeroDePiso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numeroDeCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
    }
}