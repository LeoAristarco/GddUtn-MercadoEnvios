namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class GenerarPubliForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hayEnvio = new System.Windows.Forms.CheckBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.fechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.estado = new System.Windows.Forms.ComboBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.visibilidad = new System.Windows.Forms.ComboBox();
            this.rubro = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rubro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.hayEnvio);
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.fechaFinalizacion);
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.visibilidad);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(479, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creación o Modificación de Publicación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Envio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rubro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de Finalización";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Visibilidad";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 514);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 11;
            this.button4.Text = "<< Volver";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hayEnvio
            // 
            this.hayEnvio.AutoSize = true;
            this.hayEnvio.Location = new System.Drawing.Point(195, 460);
            this.hayEnvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hayEnvio.Name = "hayEnvio";
            this.hayEnvio.Size = new System.Drawing.Size(88, 21);
            this.hayEnvio.TabIndex = 8;
            this.hayEnvio.Text = "hayEnvio";
            this.hayEnvio.UseVisualStyleBackColor = true;
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(195, 414);
            this.precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(232, 27);
            this.precio.TabIndex = 7;
            // 
            // fechaFinalizacion
            // 
            this.fechaFinalizacion.Location = new System.Drawing.Point(195, 167);
            this.fechaFinalizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaFinalizacion.Name = "fechaFinalizacion";
            this.fechaFinalizacion.Size = new System.Drawing.Size(232, 22);
            this.fechaFinalizacion.TabIndex = 5;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(195, 247);
            this.tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(232, 24);
            this.tipo.TabIndex = 4;
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Location = new System.Drawing.Point(195, 207);
            this.estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(232, 24);
            this.estado.TabIndex = 3;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(195, 122);
            this.stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stock.Multiline = true;
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(232, 27);
            this.stock.TabIndex = 2;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(195, 74);
            this.descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(232, 27);
            this.descripcion.TabIndex = 1;
            // 
            // visibilidad
            // 
            this.visibilidad.FormattingEnabled = true;
            this.visibilidad.Location = new System.Drawing.Point(195, 31);
            this.visibilidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visibilidad.Name = "visibilidad";
            this.visibilidad.Size = new System.Drawing.Size(232, 24);
            this.visibilidad.TabIndex = 0;
            // 
            // rubro
            // 
            this.rubro.FormattingEnabled = true;
            this.rubro.Location = new System.Drawing.Point(195, 290);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(232, 24);
            this.rubro.TabIndex = 21;
            // 
            // GenerarPubliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 586);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenerarPubliForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GenerarPubliForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox hayEnvio;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.DateTimePicker fechaFinalizacion;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.ComboBox visibilidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox rubro;
    }
}