namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class CrearCliente
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
            this.back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numeroDePiso = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numeroDeCalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.tiposDocumento = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.calle = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(303, 591);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(113, 37);
            this.limpiarButton.TabIndex = 6;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 591);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 37);
            this.back.TabIndex = 3;
            this.back.Text = "<< Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaNacimiento);
            this.groupBox1.Controls.Add(this.localidad);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.departamento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numeroDePiso);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numeroDeCalle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.registrar);
            this.groupBox1.Controls.Add(this.tiposDocumento);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.codigoPostal);
            this.groupBox1.Controls.Add(this.calle);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.numeroDocumento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 570);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo cliente";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(187, 486);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(201, 22);
            this.fechaNacimiento.TabIndex = 30;
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(187, 404);
            this.localidad.Margin = new System.Windows.Forms.Padding(4);
            this.localidad.MaxLength = 255;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(201, 22);
            this.localidad.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 408);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Localidad ";
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(187, 363);
            this.departamento.Margin = new System.Windows.Forms.Padding(4);
            this.departamento.MaxLength = 255;
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(201, 22);
            this.departamento.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 367);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = " Departamento";
            // 
            // numeroDePiso
            // 
            this.numeroDePiso.Location = new System.Drawing.Point(187, 323);
            this.numeroDePiso.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDePiso.MaxLength = 255;
            this.numeroDePiso.Name = "numeroDePiso";
            this.numeroDePiso.Size = new System.Drawing.Size(201, 22);
            this.numeroDePiso.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 327);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Numero de piso";
            // 
            // numeroDeCalle
            // 
            this.numeroDeCalle.Location = new System.Drawing.Point(187, 282);
            this.numeroDeCalle.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDeCalle.MaxLength = 255;
            this.numeroDeCalle.Name = "numeroDeCalle";
            this.numeroDeCalle.Size = new System.Drawing.Size(201, 22);
            this.numeroDeCalle.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Numero de calle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 529);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "(*) = Campo obligatorio";
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(187, 519);
            this.registrar.Margin = new System.Windows.Forms.Padding(4);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(203, 37);
            this.registrar.TabIndex = 11;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // tiposDocumento
            // 
            this.tiposDocumento.FormattingEnabled = true;
            this.tiposDocumento.Location = new System.Drawing.Point(187, 95);
            this.tiposDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.tiposDocumento.Name = "tiposDocumento";
            this.tiposDocumento.Size = new System.Drawing.Size(201, 24);
            this.tiposDocumento.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(187, 21);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.MaxLength = 255;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(201, 22);
            this.nombre.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(187, 58);
            this.apellido.Margin = new System.Windows.Forms.Padding(4);
            this.apellido.MaxLength = 255;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(201, 22);
            this.apellido.TabIndex = 1;
            // 
            // codigoPostal
            // 
            this.codigoPostal.Location = new System.Drawing.Point(187, 445);
            this.codigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.codigoPostal.MaxLength = 50;
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(201, 22);
            this.codigoPostal.TabIndex = 7;
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(187, 242);
            this.calle.Margin = new System.Windows.Forms.Padding(4);
            this.calle.MaxLength = 255;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(201, 22);
            this.calle.TabIndex = 6;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(187, 206);
            this.telefono.Margin = new System.Windows.Forms.Padding(4);
            this.telefono.MaxLength = 18;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(201, 22);
            this.telefono.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(187, 169);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.MaxLength = 255;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 22);
            this.email.TabIndex = 4;
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Location = new System.Drawing.Point(187, 132);
            this.numeroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.numeroDocumento.MaxLength = 18;
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(201, 22);
            this.numeroDocumento.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 486);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de nacimiento (*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Código Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Calle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail (*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de documento (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de documento (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 631);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearCliente";
            this.Text = "ABMClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearCliente_FormClosing);
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.ComboBox tiposDocumento;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox numeroDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numeroDePiso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numeroDeCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
    }
}