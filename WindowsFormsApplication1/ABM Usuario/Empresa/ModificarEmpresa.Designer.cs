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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habilitado = new System.Windows.Forms.CheckBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rubro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nombreDeContacto = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ciudad = new System.Windows.Forms.TextBox();
            this.numeroDePiso = new System.Windows.Forms.TextBox();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.numeroDeCalle = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(177, 631);
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
            this.bVolver.Location = new System.Drawing.Point(7, 631);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(113, 37);
            this.bVolver.TabIndex = 4;
            this.bVolver.Text = "<< Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rubro);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.localidad);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.calle);
            this.groupBox2.Controls.Add(this.nombreDeContacto);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.departamento);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.ciudad);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.numeroDePiso);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.codigoPostal);
            this.groupBox2.Controls.Add(this.numeroDeCalle);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.telefono);
            this.groupBox2.Location = new System.Drawing.Point(13, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(400, 461);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos corporativos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habilitado);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.nick);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos identificatorios";
            // 
            // habilitado
            // 
            this.habilitado.AutoSize = true;
            this.habilitado.Location = new System.Drawing.Point(176, 107);
            this.habilitado.Name = "habilitado";
            this.habilitado.Size = new System.Drawing.Size(18, 17);
            this.habilitado.TabIndex = 10;
            this.habilitado.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(176, 71);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.MaxLength = 255;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(219, 22);
            this.pass.TabIndex = 7;
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(176, 34);
            this.nick.Margin = new System.Windows.Forms.Padding(4);
            this.nick.MaxLength = 255;
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(219, 22);
            this.nick.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habilitado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de usuario";
            // 
            // rubro
            // 
            this.rubro.Location = new System.Drawing.Point(185, 419);
            this.rubro.Margin = new System.Windows.Forms.Padding(4);
            this.rubro.MaxLength = 50;
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(201, 22);
            this.rubro.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Rubro (*)";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(187, 264);
            this.localidad.Margin = new System.Windows.Forms.Padding(4);
            this.localidad.MaxLength = 255;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(201, 22);
            this.localidad.TabIndex = 86;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 268);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 87;
            this.label14.Text = "Localidad (*)";
            // 
            // nombreDeContacto
            // 
            this.nombreDeContacto.Location = new System.Drawing.Point(187, 376);
            this.nombreDeContacto.Margin = new System.Windows.Forms.Padding(4);
            this.nombreDeContacto.MaxLength = 50;
            this.nombreDeContacto.Name = "nombreDeContacto";
            this.nombreDeContacto.Size = new System.Drawing.Size(201, 22);
            this.nombreDeContacto.TabIndex = 68;
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(187, 223);
            this.departamento.Margin = new System.Windows.Forms.Padding(4);
            this.departamento.MaxLength = 255;
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(201, 22);
            this.departamento.TabIndex = 84;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 227);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 17);
            this.label16.TabIndex = 85;
            this.label16.Text = " Departamento (*)";
            // 
            // ciudad
            // 
            this.ciudad.Location = new System.Drawing.Point(187, 339);
            this.ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.ciudad.MaxLength = 50;
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(201, 22);
            this.ciudad.TabIndex = 66;
            // 
            // numeroDePiso
            // 
            this.numeroDePiso.Location = new System.Drawing.Point(187, 183);
            this.numeroDePiso.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDePiso.MaxLength = 255;
            this.numeroDePiso.Name = "numeroDePiso";
            this.numeroDePiso.Size = new System.Drawing.Size(201, 22);
            this.numeroDePiso.TabIndex = 82;
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(187, 303);
            this.codigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.codigoPostal.MaxLength = 50;
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(201, 22);
            this.codigoPostal.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 187);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 17);
            this.label17.TabIndex = 83;
            this.label17.Text = "Numero de piso (*)";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(187, 65);
            this.telefono.Margin = new System.Windows.Forms.Padding(4);
            this.telefono.MaxLength = 18;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(201, 22);
            this.telefono.TabIndex = 62;
            // 
            // numeroDeCalle
            // 
            this.numeroDeCalle.Location = new System.Drawing.Point(187, 142);
            this.numeroDeCalle.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDeCalle.MaxLength = 255;
            this.numeroDeCalle.Name = "numeroDeCalle";
            this.numeroDeCalle.Size = new System.Drawing.Size(201, 22);
            this.numeroDeCalle.TabIndex = 80;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(187, 28);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 22);
            this.email.TabIndex = 61;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 146);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(130, 17);
            this.label18.TabIndex = 81;
            this.label18.Text = "Numero de calle (*)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 69;
            this.label19.Text = "Teléfono";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 306);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 17);
            this.label20.TabIndex = 70;
            this.label20.Text = "Código postal (*)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 380);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 17);
            this.label21.TabIndex = 73;
            this.label21.Text = "Nombre de contacto";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(187, 102);
            this.calle.Margin = new System.Windows.Forms.Padding(4);
            this.calle.MaxLength = 255;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(201, 22);
            this.calle.TabIndex = 74;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 342);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 17);
            this.label22.TabIndex = 71;
            this.label22.Text = "Ciudad";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 32);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 17);
            this.label23.TabIndex = 72;
            this.label23.Text = "E-mail (*)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 106);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 17);
            this.label25.TabIndex = 75;
            this.label25.Text = "Calle (*)";
            // 
            // ModificarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 683);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarEmpresa";
            this.Text = "ModificarEmpresa";
            this.Load += new System.EventHandler(this.ModificarEmpresa_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox habilitado;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rubro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.TextBox nombreDeContacto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ciudad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox numeroDePiso;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.TextBox numeroDeCalle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox telefono;
    }
}