namespace WindowsFormsApplication1.ABM_Usuario.Cliente
{
    partial class Confirmacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.tGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tGB
            // 
            this.tGB.Controls.Add(this.label3);
            this.tGB.Controls.Add(this.pass);
            this.tGB.Controls.Add(this.label4);
            this.tGB.Controls.Add(this.nick);
            this.tGB.Location = new System.Drawing.Point(13, 68);
            this.tGB.Margin = new System.Windows.Forms.Padding(4);
            this.tGB.Name = "tGB";
            this.tGB.Padding = new System.Windows.Forms.Padding(4);
            this.tGB.Size = new System.Drawing.Size(363, 98);
            this.tGB.TabIndex = 10;
            this.tGB.TabStop = false;
            this.tGB.Text = "Datos de acceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Usuario:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(151, 58);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Size = new System.Drawing.Size(199, 24);
            this.pass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(151, 27);
            this.nick.Margin = new System.Windows.Forms.Padding(4);
            this.nick.Multiline = true;
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Size = new System.Drawing.Size(199, 24);
            this.nick.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Puede ingresar al sistema con los siguientes datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Alta de usuario realizada exitosamente.";
            // 
            // Confirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tGB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Confirmacion";
            this.Text = "Confirmacion";
            this.Load += new System.EventHandler(this.Confirmacion_Load);
            this.tGB.ResumeLayout(false);
            this.tGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox tGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}